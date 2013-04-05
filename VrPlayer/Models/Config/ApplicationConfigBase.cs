﻿using VrPlayer.Helpers.Mvvm;

namespace VrPlayer.Models.Config
{
    public abstract class ApplicationConfigBase : ViewModelBase, IApplicationConfig
    {
        private string _defaultMediaFile;
        private string _samplesFolder;
        private double _barrelFactor;
        private double _pincushionFactor;
        private int _cameraFieldOfView;
        private int _mouseSensitivity;
        private double _depthMapMaxOffset;
        private string _colorKeyAlphaColor;
        private double _colorKeyTolerance;
        private int _orientationRefreshRateInMs;
        private int _viewportsHorizontalOffset;
        private double _hydraPositionScaleFactor;
        private double _hydraPitchOffset;
        private double _psMovePositionScaleFactor;
        private double _kinectPositionScaleFactor;
        private double _vrpnPositionScaleFactor;
        private string _vrpnTrackerAddress;
        private string _vrpnButtonAddress;
        private bool _positionalAudio;
        private bool _evrRendering;
        private int _domeSlices;
        private int _domeStacks;
        private int _sphereSlices;
        private int _sphereStacks;
        private int _cylinderSlices;
        private int _cylinderStacks;

        public string DefaultMediaFile
        {
            get { return _defaultMediaFile; }
            set
            {
                _defaultMediaFile = value;
                OnPropertyChanged("DefaultMediaFile");
            }
        }

        public string SamplesFolder
        {
            get { return _samplesFolder; }
            set 
            { 
                _samplesFolder = value;
                OnPropertyChanged("SamplesFolder");
            }
        }

        public double BarrelFactor
        {
            get { return _barrelFactor; }
            set
            {
                _barrelFactor = value;
                OnPropertyChanged("BarrelFactor");
            }
        }

        public double PincushionFactor
        {
            get { return _pincushionFactor; }
            set
            {
                _pincushionFactor = value;
                OnPropertyChanged("PincushionFactor");
            }
        }

        public int CameraFieldOfView
        {
            get { return _cameraFieldOfView; }
            set
            {
                _cameraFieldOfView = value;
                OnPropertyChanged("CameraFieldOfView");
            }
        }

        public int MouseSensitivity
        {
            get { return _mouseSensitivity; }
            set
            {
                _mouseSensitivity = value;
                OnPropertyChanged("MouseSensitivity");
            }
        }

        public double DepthMapMaxOffset
        {
            get { return _depthMapMaxOffset; }
            set
            {
                _depthMapMaxOffset = value;
                OnPropertyChanged("DepthMapMaxOffset");
            }
        }

        public string ColorKeyAlphaColor
        {
            get { return _colorKeyAlphaColor; }
            set
            {
                _colorKeyAlphaColor = value;
                OnPropertyChanged("ColorKeyAlphaColor");
            }
        }

        public double ColorKeyTolerance
        {
            get { return _colorKeyTolerance; }
            set
            {
                _colorKeyTolerance = value;
                OnPropertyChanged("ColorKeyTolerance");
            }
        }

        public int OrientationRefreshRateInMS
        {
            get { return _orientationRefreshRateInMs; }
            set
            {
                _orientationRefreshRateInMs = value;
                OnPropertyChanged("OrientationRefreshRateInMS");
            }
        }

        public int ViewportsHorizontalOffset
        {
            get { return _viewportsHorizontalOffset; }
            set
            {
                _viewportsHorizontalOffset = value;
                OnPropertyChanged("ViewportsHorizontalOffset");
            }
        }

        public double HydraPositionScaleFactor
        {
            get { return _hydraPositionScaleFactor; }
            set
            {
                _hydraPositionScaleFactor = value;
                OnPropertyChanged("HydraPositionScaleFactor");
            }
        }

        public double HydraPitchOffset
        {
            get { return _hydraPitchOffset; }
            set
            {
                _hydraPitchOffset = value;
                OnPropertyChanged("HydraPitchOffset");
            }
        }

        public double PsMovePositionScaleFactor
        {
            get { return _psMovePositionScaleFactor; }
            set
            {
                _psMovePositionScaleFactor = value;
                OnPropertyChanged("PsMovePositionScaleFactor");
            }
        }

        public double KinectPositionScaleFactor
        {
            get { return _kinectPositionScaleFactor; }
            set
            {
                _kinectPositionScaleFactor = value;
                OnPropertyChanged("KinectPositionScaleFactor");
            }
        }

        public double VrpnPositionScaleFactor
        {
            get { return _vrpnPositionScaleFactor; }
            set
            {
                _vrpnPositionScaleFactor = value;
                OnPropertyChanged("VrpnPositionScaleFactor");
            }
        }

        public string VrpnTrackerAddress
        {
            get { return _vrpnTrackerAddress; }
            set
            {
                _vrpnTrackerAddress = value;
                OnPropertyChanged("VrpnTrackerAddress");
            }
        }

        public string VrpnButtonAddress
        {
            get { return _vrpnButtonAddress; }
            set
            {
                _vrpnButtonAddress = value;
                OnPropertyChanged("VrpnButtonAddress");
            }
        }

        public bool PositionalAudio
        {
            get { return _positionalAudio; }
            set
            {
                _positionalAudio = value;
                OnPropertyChanged("PositionalAudio");
            }
        }

        public bool EvrRendering
        {
            get { return _evrRendering; }
            set
            {
                _evrRendering = value;
                OnPropertyChanged("EvrRendering");
            }
        }

        public int DomeSlices
        {
            get { return _domeSlices; }
            set
            {
                _domeSlices = value;
                OnPropertyChanged("DomeSlices");
            }
        }

        public int DomeStacks
        {
            get { return _domeStacks; }
            set
            {
                _domeStacks = value;
                OnPropertyChanged("DomeStacks");
            }
        }

        public int SphereSlices
        {
            get { return _sphereSlices; }
            set
            {
                _sphereSlices = value;
                OnPropertyChanged("SphereSlices");
            }
        }

        public int SphereStacks
        {
            get { return _sphereStacks; }
            set
            {
                _sphereStacks = value;
                OnPropertyChanged("SphereStacks");
            }
        }

        public int CylinderSlices
        {
            get { return _cylinderSlices; }
            set
            {
                _cylinderSlices = value;
                OnPropertyChanged("CylinderSlices");
            }
        }

        public int CylinderStacks
        {
            get { return _cylinderStacks; }
            set
            {
                _cylinderStacks = value;
                OnPropertyChanged("CylinderStacks");
            }
        }
    }
}