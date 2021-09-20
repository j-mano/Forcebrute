using System;
using Brute_Force_Sevices.Services;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton3Activated(object sender, EventArgs e)
    {
        try
        {
            if(InputValidation())
            {
                // Printing out decrypted chyper from the decrypt class wich get the inputed chyper.
                Output_Entry.Text = Brute_Force_Sevices.Services.BruteForceCalc.Bruteforcecalc(Input_Entry.Text);
            }
            else
            {
                throw new InvalidOperationException("Error while brute force text.");
            }
        }
        catch(Exception generalexeption)
        {
            Output_Entry.Text = "error:" + generalexeption;
            Console.WriteLine("error:" + generalexeption);
        }
    }

    protected void OnExitBTNClicked(object sender, EventArgs e)
    {
        System.Environment.Exit(1);
    }

    private bool InputValidation()
    {
        bool returnbool = false;

        if (Input_Entry.Text.Length > 3)
        {
            returnbool = true;
        }

        return returnbool;
    }

    protected void OnSaveBTNClicked(object sender, EventArgs e)
    {
        try
        {
            SaveToTextFile.Save(Output_Entry.Text, Input_Entry.Text);
        }
        catch(Exception generalexeption)
        {
            Output_Entry.Text = "Error:" + generalexeption;
            Console.WriteLine("" + generalexeption);
        }
    }
}
