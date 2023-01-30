﻿using Dalamud.Game.ClientState.Objects.SubKinds;
using Dalamud.Game.ClientState.Objects.Types;
using Dalamud.Interface.Colors;
using ECommons;
using ECommons.DalamudServices;
using Splatoon.SplatoonScripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SplatoonScriptsOfficial.Duties.Endwalker.The_Omega_Protocol
{
    public class Hello_World : SplatoonScript
    {
        public override HashSet<uint> ValidTerritories => new() { 1122 };
        bool RotPicker = false;

        public class Effects
        {
            /// <summary>
            /// _rsv_3429_-1_1_0_0_S74CFC3B0_E74CFC3B0 (3429), Remains = 15.2, Param = 0, Count = 0
            /// </summary>
            public const uint BlueRot = 3429;

            public const uint RedRot = 3526;

            /// <summary>
            /// Critical Overflow Bug (3525), Remains = 9.2, Param = 0, Count = 0
            /// </summary>
            public const uint Defamation = 3525;

            public const uint StackTwoPeople = 3524;

            /// <summary>
            /// Remote Code Smell (3441), Remains = 8.0, Param = 0, Count = 0<br></br>
            /// tethers that break when far, must be <10 seconds remaining
            /// </summary>
            public const uint UpcomingFarTether = 3441;

            /// <summary>
            ///   Local Code Smell (3503), Remains = 50.0, Param = 0, Count = 0<br></br>
            ///   tethers that break when close, must be <10 seconds remaining
            /// </summary>
            public const uint UpcomingCloseTether = 3503;

            /// <summary>
            /// Remote Regression (3530), Remains = 9.6, Param = 0, Count = 0<br></br>
            /// must be broken first, picks up corresponding rot first
            /// </summary>
            public const uint FarTether = 3530;

            /// <summary>
            ///   Local Regression (3529), Remains = 9.6, Param = 0, Count = 0
            ///   must be broken second
            /// </summary>
            public const uint CloseTether = 3529;


        }

        public override void OnSetup()
        {
            Controller.RegisterElementFromCode("RedTower", "{\"Name\":\"Red\",\"type\":1,\"Enabled\":false,\"radius\":6.0,\"thicc\":4.0,\"refActorName\":\"*\",\"refActorRequireCast\":true,\"refActorCastId\":[31583],\"includeRotation\":false,\"tether\":true}");
            Controller.RegisterElementFromCode("BlueTower", "{\"Name\":\"Blue\",\"type\":1,\"Enabled\":false,\"radius\":6.0,\"color\":3372220160,\"thicc\":4.0,\"refActorName\":\"*\",\"refActorRequireCast\":true,\"refActorCastId\":[31584],\"includeRotation\":false,\"tether\":true}");
            Controller.RegisterElementFromCode("Reminder", "{\"Name\":\"\",\"type\":1,\"Enabled\":false,\"offZ\":3.5,\"overlayBGColor\":4278190335,\"overlayTextColor\":4294967295,\"overlayFScale\":2.0,\"overlayText\":\"REMINDER\",\"refActorType\":1}");
        }

        public override void OnUpdate()
        {
            if (Svc.Objects.Any(x => x is BattleChara b && b.CastActionId == 31599))
            {
                var isDefamationRed = Svc.Objects.Any(x => x is PlayerCharacter pc && HasEffect(Effects.Defamation, null, pc) && HasEffect(Effects.RedRot, null, pc));
                if (HasEffect(Effects.RedRot))
                {
                    TowerRed(false);
                    if (HasEffect(Effects.Defamation))
                    {
                        Reminder("Defamation: inside red tower edge", ImGuiColors.DalamudRed);
                    }
                    else
                    {
                        Reminder("Inside red tower >>stack<<", ImGuiColors.DalamudRed);
                    }
                }
                if (HasEffect(Effects.BlueRot))
                {
                    TowerBlue(false);
                    if (HasEffect(Effects.Defamation))
                    {
                        Reminder("Defamation: inside blue tower edge", ImGuiColors.TankBlue);
                    }
                    else
                    {
                        Reminder("Inside blue tower >>stack<<", ImGuiColors.TankBlue);
                    }
                }
                if(HasEffect(Effects.UpcomingCloseTether, 10f))
                {
                    RotPicker = true;
                    if (isDefamationRed)
                    {
                        TowerRed(true);
                        Reminder("Far out of red tower - pick up DEFAMATION", ImGuiColors.DalamudRed);
                    }
                    else
                    {
                        TowerBlue(true);
                        Reminder("Far out of blue tower - pick up DEFAMATION", ImGuiColors.TankBlue);
                    }
                }
                if (HasEffect(Effects.UpcomingFarTether))
                {
                    RotPicker = true;
                    if (isDefamationRed)
                    {
                        TowerBlue(true);
                        Reminder("Between blue towers - STACK", ImGuiColors.TankBlue);
                    }
                    else
                    {
                        TowerRed(true);
                        Reminder("Between red towers - STACK", ImGuiColors.DalamudRed);
                    }
                }
            }
            else
            {
                TowerOff();
                Reminder(null);
                if (RotPicker)
                {
                    Reminder("Pick up rot", 0xFF000000.ToVector4());
                    if(HasEffect(Effects.BlueRot) || HasEffect(Effects.RedRot))
                    {
                        RotPicker = false;
                    }
                }
                else
                {
                    if (HasEffect(Effects.FarTether))
                    {
                        Reminder("Break tethers - go FAR", ImGuiColors.HealerGreen);
                    }
                    if (HasEffect(Effects.CloseTether) && !Svc.Objects.Any(x => x is PlayerCharacter pc && HasEffect(Effects.FarTether)))
                    {
                        Reminder("Break tethers - go CLOSE", ImGuiColors.ParsedBlue);
                    }
                }
            }
        }

        void TowerRed(bool filled)
        {
            Controller.GetElementByName("RedTower").Enabled = true;
            Controller.GetElementByName("BlueTower").Enabled = false;
            Controller.GetElementByName("RedTower").color = (Controller.GetElementByName("RedTower").color.ToVector4() with { W = filled ? 0.3f : 0.8f }).ToUint();
            Controller.GetElementByName("RedTower").Filled = filled;
        }

        void TowerBlue(bool filled)
        {
            Controller.GetElementByName("RedTower").Enabled = false;
            Controller.GetElementByName("BlueTower").Enabled = true;
            Controller.GetElementByName("BlueTower").color = (Controller.GetElementByName("BlueTower").color.ToVector4() with { W = filled ? 0.3f : 0.8f }).ToUint();
            Controller.GetElementByName("BlueTower").Filled = filled;
        }

        void TowerOff()
        {
            Controller.GetElementByName("RedTower").Enabled = false;
            Controller.GetElementByName("BlueTower").Enabled = false;
        }

        static bool HasEffect(uint effect, float? remainingTile = null, BattleChara? obj = null)
        {
            return (obj ?? Svc.ClientState.LocalPlayer).StatusList.Any(x => x.StatusId == effect && (remainingTile == null || x.RemainingTime < remainingTile));
        }

        void Reminder(string? text, Vector4? color = null)
        {
            if(Controller.TryGetElementByName("Reminder", out var e))
            {
                if (text == null)
                {
                    e.Enabled = false;
                }
                else
                {
                    e.Enabled = true;
                    e.overlayText = text;
                }
                if (color != null)
                {
                    e.overlayBGColor = color.Value.ToUint();
                }
            }
        }
    }
}