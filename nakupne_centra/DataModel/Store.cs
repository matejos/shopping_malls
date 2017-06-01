﻿namespace nakupne_centra.DataModel
{
    public class Store
    {
        public Store(Centre centre, string name, string description, string category, string floor, Hours hours)
        {
            this.Centre = centre;
            this.Name = name;
            this.Description = description;
            this.Category = category;
            this.Floor = floor;
            this.StoreHours = hours;
        }

        public Centre Centre { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Category { get; private set; }
        public string Floor { get; private set; }
        public Hours StoreHours { get; private set; }
    }
}
