﻿// This file is part of iRacingReplayOverlay.
//
// Copyright 2014 Dean Netherton
// https://github.com/vipoo/iRacingReplayOverlay.net
//
// iRacingReplayOverlay is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// iRacingReplayOverlay is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with iRacingReplayOverlay.  If not, see <http://www.gnu.org/licenses/>.

using iRacingReplayOverlay;
using iRacingReplayOverlay.Phases;
using iRacingSDK;
using System.IO;
using System.Linq;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingFolder = Path.GetDirectoryName(typeof(Program).Assembly.Location);

            var trackCameras = InitCameras();

            new IRacingReplay()
                .WithCameras(trackCameras)
                .WhenIRacingStarts(() => { })
                .AnalyseRace(() => { })
                .WithWorkingFolder(workingFolder)
                .CaptureOpeningScenes()
                .CaptureRace(f => { })
                .CloseIRacing()
                .WithEncodingOf(videoBitRate: 5000000)
                .OverlayRaceDataOntoVideo((c, d) => { }, () => { }, false, false)
                .InTheForeground();
        }

        private static TrackCameras InitCameras()
        {
            var data = iRacing.GetDataFeed().First();
            var trackName = data.SessionData.WeekendInfo.TrackDisplayName;

            var trackCameras = new TrackCameras();

            foreach (var camera in data.SessionData.CameraInfo.Groups)
                trackCameras.Add(new TrackCamera
                {
                    TrackName = trackName,
                    CameraName = camera.GroupName
                });

            return trackCameras;
        }
    }
}
