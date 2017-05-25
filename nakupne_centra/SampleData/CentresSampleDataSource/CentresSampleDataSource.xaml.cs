﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Blend.SampleData.CentresSampleDataSource
{
    using System; 
    using System.ComponentModel;

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
    internal class CentresSampleDataSource { }
#else

    public class CentresSampleDataSource : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public CentresSampleDataSource()
        {
            try
            {
                Uri resourceUri = new Uri("ms-appx:/SampleData/CentresSampleDataSource/CentresSampleDataSource.xaml", UriKind.RelativeOrAbsolute);
                Windows.UI.Xaml.Application.LoadComponent(this, resourceUri);
            }
            catch
            {
            }
        }

        private Centres _Centres = new Centres();

        public Centres Centres
        {
            get
            {
                return this._Centres;
            }
        }
    }

    public class Centres : System.Collections.ObjectModel.ObservableCollection<CentresItem>
    { 
    }

    public class CentresItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private Hours _Hours = new Hours();

        public Hours Hours
        {
            get
            {
                return this._Hours;
            }

            set
            {
                if (this._Hours != value)
                {
                    this._Hours = value;
                    this.OnPropertyChanged("Hours");
                }
            }
        }

        private string _Name = string.Empty;

        public string Name
        {
            get
            {
                return this._Name;
            }

            set
            {
                if (this._Name != value)
                {
                    this._Name = value;
                    this.OnPropertyChanged("Name");
                }
            }
        }

        private Windows.UI.Xaml.Media.ImageSource _LogoBig = null;

        public Windows.UI.Xaml.Media.ImageSource LogoBig
        {
            get
            {
                return this._LogoBig;
            }

            set
            {
                if (this._LogoBig != value)
                {
                    this._LogoBig = value;
                    this.OnPropertyChanged("LogoBig");
                }
            }
        }

        private Windows.UI.Xaml.Media.ImageSource _LogoSmall = null;

        public Windows.UI.Xaml.Media.ImageSource LogoSmall
        {
            get
            {
                return this._LogoSmall;
            }

            set
            {
                if (this._LogoSmall != value)
                {
                    this._LogoSmall = value;
                    this.OnPropertyChanged("LogoSmall");
                }
            }
        }
    }

    public class Hours : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _Monday = string.Empty;

        public string Monday
        {
            get
            {
                return this._Monday;
            }

            set
            {
                if (this._Monday != value)
                {
                    this._Monday = value;
                    this.OnPropertyChanged("Monday");
                }
            }
        }

        private string _Tuesday = string.Empty;

        public string Tuesday
        {
            get
            {
                return this._Tuesday;
            }

            set
            {
                if (this._Tuesday != value)
                {
                    this._Tuesday = value;
                    this.OnPropertyChanged("Tuesday");
                }
            }
        }

        private string _Wednesday = string.Empty;

        public string Wednesday
        {
            get
            {
                return this._Wednesday;
            }

            set
            {
                if (this._Wednesday != value)
                {
                    this._Wednesday = value;
                    this.OnPropertyChanged("Wednesday");
                }
            }
        }

        private string _Thursday = string.Empty;

        public string Thursday
        {
            get
            {
                return this._Thursday;
            }

            set
            {
                if (this._Thursday != value)
                {
                    this._Thursday = value;
                    this.OnPropertyChanged("Thursday");
                }
            }
        }

        private string _Friday = string.Empty;

        public string Friday
        {
            get
            {
                return this._Friday;
            }

            set
            {
                if (this._Friday != value)
                {
                    this._Friday = value;
                    this.OnPropertyChanged("Friday");
                }
            }
        }

        private string _Saturday = string.Empty;

        public string Saturday
        {
            get
            {
                return this._Saturday;
            }

            set
            {
                if (this._Saturday != value)
                {
                    this._Saturday = value;
                    this.OnPropertyChanged("Saturday");
                }
            }
        }

        private string _Sunday = string.Empty;

        public string Sunday
        {
            get
            {
                return this._Sunday;
            }

            set
            {
                if (this._Sunday != value)
                {
                    this._Sunday = value;
                    this.OnPropertyChanged("Sunday");
                }
            }
        }
    }
#endif
}
