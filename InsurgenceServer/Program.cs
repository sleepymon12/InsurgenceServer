﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace InsurgenceServer
{
	public class MainClass
	{
		public static void Main(string[] args)
		{
            System.AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;
            MainClass c = new MainClass();
            c.Begin();
		}
        public void Begin()
        {
            Console.WriteLine("Starting Server!");
            Console.WriteLine("Setting up tiers");
            Battles.Matchmaking.SetupTiers();
            Console.WriteLine("Setting up database!");
            Database.DBInit.Connect();

            new Thread(() =>
                Battles.RandomBattles.MatchRandoms()
            ).Start();

            new Thread(() =>
                ClientHandler.ClientChecker()
            ).Start();

            new MainConnector();
        }
        static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine(e.ExceptionObject.ToString());
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Environment.Exit(1);
        }
    }
}
