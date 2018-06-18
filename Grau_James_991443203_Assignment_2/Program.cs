/**
 * 
 * File: Program.cs
 * Date: June 16, 2018
 * Name: James Grau
 * Student Id: 991443203
 * 
 **/

// Include needed packages
using System;
using System.Windows.Forms;

// Declare Namespace 
namespace Grau_James_991443203_Assignment_2 {
    // Class to handle Program
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // Initialize and then display the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
