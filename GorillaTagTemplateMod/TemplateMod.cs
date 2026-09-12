using BepInEx;
using GorillaExtensions;
using GorillaLocomotion;
using GorillaLocomotion.Climbing;
using GorillaLocomotion.Swimming;
using HarmonyLib;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using Valve.VR;
using System.IO;
using System.Diagnostics;
using System.Collections;
using UnityEngine.Networking;
using System.Threading;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR;
using GorillaGameModes;
using Photon;
using GorillaNetworking;
using GorillaTag.Rendering;
using Valve.VR.InteractionSystem;
using static Unity.Burst.Intrinsics.X86;
using Random = UnityEngine.Random;

namespace Templatemod
{
    [BepInPlugin("com.Dev.TemplateMod", "TemplateMod", "1.0.0")]
    public class Mod : BaseUnityPlugin
    {
        private GTPlayer player
        {
            get { return GTPlayer.Instance; }
        }
        private GorillaTagger gorillatagger
        {
            get { return GorillaTagger.Instance; }
        }
        private Rigidbody arb
        {
            get { return player.bodyCollider.attachedRigidbody; }
        }
        private SphereCollider head
        {
            get { return player.headCollider; }
        }
        private CapsuleCollider body
        {
            get { return player.bodyCollider; }
        }
        private Rigidbody rb
        {
            get { return player.GetComponent<Rigidbody>(); }
        }
        private GTPlayer.HandState lefthand
        {
            get { return player.LeftHand; }
        }
        private GTPlayer.HandState righthand
        {
            get { return player.RightHand; }
        }
        private void Update()
        {
        if (GTPlayer.Instance == null) return;
        if (GorillaTagger.Instance == null) return;


        
        }
        private void OnGUI()
        {

        }
    }
}
