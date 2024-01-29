﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeVideoLoader
{
    public interface ICommand
    {
        Task ExecuteAsync(string videoUrl);
    }
}