﻿using System.Collections.ObjectModel;
using Xamarin.Forms.Gallery.Models;
using Xamarin.Forms.Gallery.Services;

namespace Xamarin.Forms.Gallery.ViewModels
{
    public class GalleryViewModel : BindableObject
    {
        ObservableCollection<ShowcaseItem> _showcase;
        ObservableCollection<GalleryCategory> _gallery;

        public GalleryViewModel()
        {
            LoadData();
        }

        public ObservableCollection<ShowcaseItem> Showcase
        {
            get { return _showcase; }
            set
            {
                _showcase = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<GalleryCategory> Gallery
        {
            get { return _gallery; }
            set
            {
                _gallery = value;
                OnPropertyChanged();
            }
        }

        void LoadData()
        {
            var showcaseItems = GalleryService.Instance.GetShowcaseItems();
            Showcase = new ObservableCollection<ShowcaseItem>(showcaseItems);

            var galleryItems = GalleryService.Instance.GetGalleryItems();
            Gallery = new ObservableCollection<GalleryCategory>(galleryItems);
        }
    }
}