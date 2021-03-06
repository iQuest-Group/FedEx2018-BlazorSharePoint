﻿namespace ScrabbleBlazor.Shared.Model
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Letter
    {
        public string Value { get; set; }

        public int Score { get; set; }

        public bool IsSelected { get; set; }

        public bool IsUsed { get; set; }

        public Letter()
        {
            this.IsSelected = false;
            this.IsUsed = false;
        }

        public Letter(string value, int score)
        {
            this.Value = value;
            this.Score = score;
            this.IsSelected = false;
            this.IsUsed = false;
        }
    }
}
