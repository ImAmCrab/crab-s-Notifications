﻿using HarmonyLib;
using StupidTemplate.Notifications;
using Photon.Pun;
using Photon.Realtime;
using System.IO;
using UnityEngine;
using static StupidTemplate.Menu.Main;

namespace StupidTemplate.Patches
{
    [HarmonyPatch(typeof(MonoBehaviourPunCallbacks), "OnPlayerEnteredRoom")]
    internal class JoinPatch : MonoBehaviour
    {
        private static void Prefix(Player newPlayer)
        {
            if (newPlayer != oldnewplayer)
            {
                NotifiLib.SendNotification("<color=grey>[</color><color=green>YAY!!!</color><color=grey>] </color><color=white>Mr: " + newPlayer.NickName + " </color><color=green>Has Joined!</color>");

                oldnewplayer = newPlayer;
            }
        }

        private static Player oldnewplayer;
    }
}