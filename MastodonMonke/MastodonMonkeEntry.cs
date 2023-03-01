﻿using System;
using ComputerInterface;
using ComputerInterface.Interfaces;

namespace MastodonMonke
{
    // An IComputerModEntry basically just describes an entry in the main menu that you can select
    public class MastodonMonkeEntry : IComputerModEntry
    {
        // This is the mod name that is going to show up as a selectable mod
        public string EntryName => "MastodonMonke";

        // This is the first view that is going to be shown if the user select you mod
        // The Computer Interface mod will instantiate your view 
        public Type EntryViewType => typeof(MastodonMonkePostView);
    }
}