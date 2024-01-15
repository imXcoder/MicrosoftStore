using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftStore.Models
{
    public class MicrosoftStoreDataObject
    { 
        public TopFreeAppsDataObject TopFreeApps { get; set; }
        public FeaturedGameAppDataObject FeaturedGameApp { get; set; }

        public MicrosoftStoreDataObject() 
        {
        }
    }

    public class TopFreeAppsDataObject
    {
        public string Title { get; set; }

        public string ImageLocation { get; set; }

        public List<AppItemDataObject> ProductList { get; set; }

        public TopFreeAppsDataObject()
        {
        }

        public static TopFreeAppsDataObject GetDataObject()
        {
            TopFreeAppsDataObject DataObject = new TopFreeAppsDataObject();

            DataObject.Title = "Top free apps";
            DataObject.ImageLocation = "/Assets/ChevronRight.png";

            List<AppItemDataObject> ItemListDataObject = new List<AppItemDataObject>();

            AppItemDataObject ITunes = new AppItemDataObject();

            ITunes.Title = "iTunes";
            ITunes.Description = "iTunes is the easiest way to enjoy everything you need to be entertained - music, movies, and TV shows - and keep it all easily organized. Rent or buy movies, download your favorite TV shows, and more.\n\niTunes is also home to Apple Music, where you can listen to millions of songs and your entire music library - ad-free with zero commercials. Plus, download your favorite music to listen without Wi-Fi. Try it free with no commitment, and cancel anytime.";
            ITunes.AverageRating = "2.5";
            ITunes.AverageRatingImageLocation = "/Assets/Rating.png";
            ITunes.Category = "Music";
            ITunes.DisplayPrice = "Free";
            ITunes.ProductId = "9PB2MZ1ZMB1S";
            ITunes.ImageLocation = "/Assets/iTunes.png";
            ITunes.ImageBackground = "#00000000";

            ItemListDataObject.Add(ITunes);

            AppItemDataObject Netflix = new AppItemDataObject();

            Netflix.Title = "Netflix";
            Netflix.Description = "Looking for the most talked about TV shows and movies from around the world? They’re all on Netflix.\r\n\r\nWe’ve got award-winning series, movies, documentaries, and stand-up specials. And with the mobile app, you get Netflix while you travel, commute, or just take a break.\r\n\r\nWhat you’ll love about Netflix:\r\n- We add TV shows and movies all the time. Browse new titles or search for your favorites, and stream videos right on your device.\r\n- The more you watch, the better Netflix gets at recommending TV shows and movies you’ll love.\r\n- Enjoy a safe watching experience just for kids with family-friendly entertainment.\r\n- Preview quick videos of our series and movies and get notifications for new episodes and releases.\r\n\r\nNetflix membership is a month-to-month paid subscription that begins at sign up. You can easily cancel anytime, online, 24 hours a day. There are no long-term contracts or cancellation fees. We just want you to love what you watch.\r\n\r\nBy clicking INSTALL, you consent to the installation of the Netflix application and any updates or upgrades thereto.";
            Netflix.AverageRating = "4.4";
            Netflix.AverageRatingImageLocation = "/Assets/Rating.png";
            Netflix.Category = "Entertainment";
            Netflix.DisplayPrice = "Free";
            Netflix.ProductId = "9WZDNCRFJ3TJ";
            Netflix.ImageLocation = "/Assets/Netflix.png";
            Netflix.ImageBackground = "#00000000";

            ItemListDataObject.Add(Netflix);

            AppItemDataObject WhatsApp = new AppItemDataObject();

            WhatsApp.Title = "WhatsApp";
            WhatsApp.Description = "WhatsApp from Meta is a 100% free messaging app. It’s used by over 2B people in more than 180 countries. It’s simple, reliable, and private, so you can easily keep in touch with your friends and family. WhatsApp works across mobile and desktop even on slow connections, with no subscription fees*.\r\n\r\nPrivate messaging across the world\r\n\r\nYour personal messages and calls to friends and family are end-to-end encrypted. No one outside of your chats, not even WhatsApp, can read or listen to them.\r\n\r\n*Data charges may apply. Contact your provider for details.\r\n\r\n---------------------------------------------------------\r\n\r\nIf you have any feedback or questions, please go to WhatsApp > Settings > Help > Contact Us";
            WhatsApp.AverageRating = "4.3";
            WhatsApp.AverageRatingImageLocation = "/Assets/Rating.png";
            WhatsApp.Category = "Social";
            WhatsApp.DisplayPrice = "Free";
            WhatsApp.ProductId = "9NKSQGP7F2NH";
            WhatsApp.ImageLocation = "/Assets/WhatsApp.png";
            WhatsApp.ImageBackground = "#00000000";

            ItemListDataObject.Add(WhatsApp);

            AppItemDataObject ICloud = new AppItemDataObject();

            ICloud.Title = "iCloud";
            ICloud.Description = "iCloud for Windows keeps your photos, files, calendar, contacts, passwords and other important information in sync between your iPhone and your Windows PC, automatically.\n\niCloud Photos\n• Keep your photos up to date across all your devices and your PC.\n• Create Shared Albums and invite others to add their own photos, videos, and comments.\n• Access, add, and remove photos and videos from your iCloud Shared Photo Library.\n• View your photos directly in the Microsoft Photos app in Windows 11.\n\niCloud Drive\n• Safely store and access your files and folders in iCloud Drive.\n• Share files with friends, family, and colleagues right from File Explorer.\n\niCloud Passwords\n• View and manage your passwords on your Windows PC in the iCloud Passwords app.\n• Save and sync your passwords across your devices and PC in Chrome or Edge using the iCloud Passwords extension.\n• Generate Time-based One-Time Passwords (TOTP) in the iCloud Passwords app.\n\niCloud Contacts, Calendars, and Bookmarks\n• Keep contacts and calendars up to date across all your devices and your PC.\n• View your iCloud Calendar in Outlook.\n• Edge, Firefox, and Google Chrome Bookmarks automatically stay up to date with Safari.\n\niCloud for Windows requires:\n• Windows 10 or later (64-bit)\n• Contacts and Calendars: requires Outlook 2019 or later\n• Passwords: requires Chrome 100 or later, or Edge 100 or later\n• Bookmarks: requires Chrome 100 or later, Firefox 92 or later, or Edge 100 or later";
            ICloud.AverageRating = "2.9";
            ICloud.AverageRatingImageLocation = "/Assets/Rating.png";
            ICloud.Category = "Productivity";
            ICloud.DisplayPrice = "Free";
            ICloud.ProductId = "9PKTQ5699M62";
            ICloud.ImageLocation = "/Assets/iCloud.png";
            ICloud.ImageBackground = "#00000000";

            ItemListDataObject.Add(ICloud);

            AppItemDataObject Spotify = new AppItemDataObject();

            Spotify.Title = "Spotify - Music and Podcasts";
            Spotify.Description = "Love music and podcasts? Play your favorite songs, podcasts and albums free on Windows with Spotify.\n \nStream the tracks you love instantly, browse the charts or fire up curated playlists in every genre and mood. Radio plays you great song after great song, based on your music taste. Discover new music too, with awesome playlists built just for you.\n \nSpotify also offers 4 million Podcasts, including originals and exclusives that you can't find anywhere else.\n \nStream Spotify free, with occasional ads, or go Premium.\n \nFree:\n• Discover, listen and download podcasts for free \n• Play any song, artist, album, playlist, or podcast instantly\n• Browse hundreds of ready made playlists in every genre and mood\n• Watch video podcasts in the mini-player or in full screen mode\n• Stay on top of the Charts\n• Enjoy playlists and mixes made just for you\n• Enjoy audiobooks and video podcasts\n• Discover more music with personalized playlists\n \nPremium:\n• Download songs, albums and playlists and play offline\n• Listen ad-free\n• Enhanced sound quality\n• Try it free for 30 days, no strings attached\n \nLike us on Facebook: http://www.facebook.com/spotify\nFollow us on Twitter: http://twitter.com/spotify";
            Spotify.AverageRating = "4.1";
            Spotify.AverageRatingImageLocation = "/Assets/Rating.png";
            Spotify.Category = "Music";
            Spotify.DisplayPrice = "Free";
            Spotify.ProductId = "9NCBCSZSJRSB";
            Spotify.ImageLocation = "/Assets/Spotify.png";
            Spotify.ImageBackground = "#1ed760";

            ItemListDataObject.Add(Spotify);

            AppItemDataObject Xbox = new AppItemDataObject();

            Xbox.Title = "Xbox";
            Xbox.Description = "Discover, download, play games, and more with PC Game Pass via the Xbox app for Windows PC. Play hundreds of PC games for one low monthly price. Download and enjoy new games on day one like Starfield from Bethesda Softworks, as well as iconic franchises like Microsoft Flight Simulator, indie games, blockbusters, and more. Launch games at the click of a button, browse the catalog, view recommendations, and more. See what friends are playing and chat while you play together. Plus, purchase favorite titles, DLC, and add-ons from the Store – all in one place.*\r\n\r\n*Xbox Game Pass sold separately";
            Xbox.AverageRating = "3.6";
            Xbox.AverageRatingImageLocation = "/Assets/Rating.png";
            Xbox.Category = "Entertainment";
            Xbox.DisplayPrice = "Free";
            Xbox.ProductId = "9MV0B5HZVK9Z";
            Xbox.ImageLocation = "/Assets/Xbox.png";
            Xbox.ImageBackground = "#107c10";

            ItemListDataObject.Add(Xbox);

            DataObject.ProductList = ItemListDataObject;

            return DataObject;
        }
    }

    public class FeaturedGameAppDataObject
    {
        public string Title { get; set; }

        public AppItemDataObject Product { get; set; }

        public static FeaturedGameAppDataObject GetDataObject()
        {
            FeaturedGameAppDataObject DataObject = new FeaturedGameAppDataObject();

            DataObject.Title = "Featured game";

            AppItemDataObject ItemDataObject = new AppItemDataObject();

            ItemDataObject.Title = "Fairyland: Merge and Magic";
            ItemDataObject.Category = "Simulation";
            ItemDataObject.ProductId = "https://apps.microsoft.com/detail/9PM92ZN1W9SD";
            ItemDataObject.ImageLocation = "/Assets/Fairyland.png";

            DataObject.Product = ItemDataObject;

            return DataObject;
        }
    }

    public class AppItemDataObject
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public string AverageRating { get; set; }

        public string AverageRatingImageLocation {  get; set; }

        public string Category { get; set; }

        public string DisplayPrice { get; set; }

        public string ProductId { get; set; }

        public string ImageLocation { get; set; }

        public string ImageBackground { get; set; }

        public AppItemDataObject()
        {
        }
    }
}
