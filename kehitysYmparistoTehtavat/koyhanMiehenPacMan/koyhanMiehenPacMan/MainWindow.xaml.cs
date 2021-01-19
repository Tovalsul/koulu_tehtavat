using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Threading;

namespace koyhanMiehenPacMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// TimeStamp 40:40/48:12
    /// Tehnyt: Tony Lehtonen
    /// </summary>
    public partial class MainWindow : Window
    {

        // DispatcherTimer on on jonkin sortin ajastin. Vielä en tiedä mitä eroa sillä on muihin valmiisiin verrattuna. 
        DispatcherTimer peliKello = new DispatcherTimer();

       // Täällä on määritelty pisteet, haamujen liikkumisnopeus ja askeleet ja pelaajalle näppäimet. Näitä sitten manipuloidaan myöhemmin.
        bool vasemmalle, oikealle, ylos, alas;
        bool eiVasemmalle, eiOikealle, eiYlos, eiAlas;

        int pacmaninNopeus = 10;

        // pacmanOsumaLaatikkoa tarvitaan tarkistamaan milloin haamut koskevat pacmaniin ja milloin pacman syö kolikoita.
        Rect pacmanOsumaLaatikko;

        int haamujenNopeus = 10;
        int haamujenAskeleet = 160;
        int tamanHetkisetHaamujenAskeleet;
        int pisteet = 0;

        public MainWindow()
        {
            InitializeComponent();

            peliSetuppi();
        }

        private void CanvasKeyDown(object sender, KeyEventArgs e)
        {
            /* Täällä on määritelty mitä tapahtuu kun painaa nuolinäppäimiä ja
                ettei se pacman ainakaan ole kohdistettu muihin suuntiin kuin itse painetun 
                nuolinäppäimen suuntaisesti.*/
            if (e.Key == Key.Left && eiVasemmalle == false)
            {
                oikealle = ylos = alas = false;
                eiOikealle = eiYlos = eiAlas = false;

                vasemmalle = true;

                pacman.RenderTransform = new RotateTransform(-180, pacman.Width / 2, pacman.Height / 2);
            }

            if (e.Key == Key.Right && eiOikealle == false)
            {
                eiVasemmalle = eiYlos = eiAlas = false;
                vasemmalle = ylos = alas = false;

                oikealle = true;

                pacman.RenderTransform = new RotateTransform(0, pacman.Width / 2, pacman.Height / 2);
            }
        
            if (e.Key == Key.Up && eiYlos == false)
            {
                oikealle = vasemmalle = alas = false;
                eiOikealle = eiVasemmalle = eiAlas = false;

                ylos = true;

                pacman.RenderTransform = new RotateTransform(-90, pacman.Width / 2, pacman.Height / 2);
            }

            if (e.Key == Key.Down && eiAlas == false)
            {
                oikealle = ylos = vasemmalle = false;
                eiOikealle = eiYlos = eiVasemmalle = false;

                alas = true;

                pacman.RenderTransform = new RotateTransform(90, pacman.Width / 2, pacman.Height / 2);
            }
        }

        private void peliSetuppi()
        {
            // peliSetuppi() on aliohjelma joka käynnistää pelin ja laittaa kellon tikittämään. Samalla se päivittää haamujen kuvat.
            peliTaulu.Focus(); // kohdistaa automaattisesti peliin ohjelman
            peliKello.Tick += peliLooppi;
            peliKello.Interval = TimeSpan.FromMilliseconds(20);
            peliKello.Start();
            tamanHetkisetHaamujenAskeleet = haamujenAskeleet;

            ImageBrush pacmanKuva = new ImageBrush();
            pacmanKuva.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/images/pacman.jpg"));
            pacman.Fill = pacmanKuva;

            ImageBrush punainenHaamu = new ImageBrush();
            punainenHaamu.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/images/red.jpg"));
            punainenJaba.Fill = punainenHaamu;                                      
                                                                                    
            ImageBrush oranssiHaamu = new ImageBrush();                             
            oranssiHaamu.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/images/orange.jpg"));
            oranssiJaba.Fill = oranssiHaamu;                                        
                                                                                    
            ImageBrush pinkkiHaamu = new ImageBrush();                              
            pinkkiHaamu.ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/images/pink.jpg"));
            pinkkiJaba.Fill = pinkkiHaamu;
           
        }

        private void peliLooppi(object sender, EventArgs e)
        {
            pisteetTeksti.Content = "Score: " + pisteet;

            if (oikealle)
            {
                Canvas.SetLeft(pacman, Canvas.GetLeft(pacman) + pacmaninNopeus);
            }

            if (vasemmalle)
            {
                Canvas.SetLeft(pacman, Canvas.GetLeft(pacman) - pacmaninNopeus);
            }

            if (ylos)
            {
                Canvas.SetTop(pacman, Canvas.GetTop(pacman) - pacmaninNopeus);
            }

            if (alas)
            {
                Canvas.SetTop(pacman, Canvas.GetTop(pacman) + pacmaninNopeus);
            }

            if (alas && Canvas.GetTop(pacman) + 80 > Application.Current.MainWindow.Height)
            {
                eiAlas = true;
                alas = false;
            }

            if (ylos && Canvas.GetTop(pacman) < 1)
            {
                eiYlos = true;
                ylos = false;
            }

            if (vasemmalle && Canvas.GetLeft(pacman) -10 < 1)
            {
                eiVasemmalle = true;
                vasemmalle = false;
            }

            if (oikealle && Canvas.GetLeft(pacman) + 70 > Application.Current.MainWindow.Width)
            {
                eiOikealle = true;
                oikealle = false;
            }

            pacmanOsumaLaatikko = new Rect(Canvas.GetLeft(pacman), Canvas.GetTop(pacman), pacman.Width, pacman.Height);

            // tämä foreach looppi liikuttaa haamuja ja tarkistaa milloin pelaaja osuu 
            // haamuun, seinään tai kolikkoon ja toimii sitten ohjeiden mukaisesti
            foreach (var x in peliTaulu.Children.OfType<Rectangle>())
            {
                Rect osumaLaatikko = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

                if ((string)x.Tag == "seina")
                {
                    if (vasemmalle == true && pacmanOsumaLaatikko.IntersectsWith(osumaLaatikko))
                    {
                        Canvas.SetLeft(pacman, Canvas.GetLeft(pacman) + 10);
                        eiVasemmalle = true;
                        vasemmalle = false;
                    }

                    if (oikealle == true && pacmanOsumaLaatikko.IntersectsWith(osumaLaatikko))
                    {
                        Canvas.SetLeft(pacman, Canvas.GetLeft(pacman) - 10);
                        eiOikealle = true;
                        oikealle = false;
                    }

                    if (alas == true && pacmanOsumaLaatikko.IntersectsWith(osumaLaatikko))
                    {
                        Canvas.SetTop(pacman, Canvas.GetTop(pacman) - 10);
                        eiAlas = true;
                        alas = false;
                    }

                    if (ylos == true && pacmanOsumaLaatikko.IntersectsWith(osumaLaatikko))
                    {
                        Canvas.SetTop(pacman, Canvas.GetTop(pacman) + 10);
                        eiYlos = true;
                        ylos = false;
                    }
                }

                if ((string)x.Tag == "kolikko")
                {
                    if (pacmanOsumaLaatikko.IntersectsWith(osumaLaatikko) && x.Visibility == Visibility.Visible)
                    {
                        x.Visibility = Visibility.Hidden;
                        kolikkoAani.Play();
                        pisteet++;
                    }
                }

                if ((string) x.Tag == "haamu")
                {
                    if (pacmanOsumaLaatikko.IntersectsWith(osumaLaatikko))
                    {
                        peliOhi("Haamut saivat sinut kiinni. Paina OK pelaaksesi uudelleen.");
                    }

                    if (x.Name.ToString() == "oranssiJaba")
                    {
                        Canvas.SetLeft(x, Canvas.GetLeft(x) - haamujenNopeus);
                    }
                    else
                    {
                        Canvas.SetLeft(x, Canvas.GetLeft(x) + haamujenNopeus);
                    }

                    tamanHetkisetHaamujenAskeleet--;

                    if (tamanHetkisetHaamujenAskeleet < 1)
                    {
                        tamanHetkisetHaamujenAskeleet = haamujenAskeleet;
                        haamujenNopeus =- haamujenNopeus;
                    }
                }
            }

            // 95 kolikkoa

            if (pisteet == 95)
            {
                peliOhi("Onneksi olkoon voitit pelin! Klikkaa OK aloittaaksesi uudelleen.");
            }
        }

        private void peliOhi(string message)
        {
            // peliOhi():a kutsuttaessa se pysäyttää pelin ja näyttää viestilaatikon pelaajalle. 
            peliKello.Stop();
            MessageBox.Show(message, "Pac Man Peli");

            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

    }
}
