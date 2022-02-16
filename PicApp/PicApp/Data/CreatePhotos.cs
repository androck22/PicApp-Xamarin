using PicApp.Data.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace PicApp.Data
{
    public class CreatePhotos
    {      
        public CreatePhotos()
        {
            Create();
        }

        public async void Create()
        {
            Photo photo1 = new Photo() { Id = new Guid("735a3848-dad1-40f6-8fb7-36d2da16f1f3"), Name = "photo1.jpg", Image = "photo1.jpg", Date = "2022-02-15" };
            Photo photo2 = new Photo() { Id = new Guid("cca22a07-5593-4485-b21d-ed7aba4ac815"), Name = "photo2.jpg", Image = "photo2.jpg", Date = "2022-02-15" };
            Photo photo3 = new Photo() { Id = new Guid("eba7c7eb-941b-4b1d-a179-21fa87a783ac"), Name = "photo3.jpg", Image = "photo3.jpg", Date = "2022-02-15" };
            Photo photo4 = new Photo() { Id = new Guid("7e19330d-23f2-4fe7-b8b7-14d3c8163e73"), Name = "photo4.jpg", Image = "photo4.jpg", Date = "2022-02-15" };
            Photo photo5 = new Photo() { Id = new Guid("6c432435-579c-4414-8d2a-07c94e20c797"), Name = "photo5.jpg", Image = "photo5.jpg", Date = "2022-02-15" };           

            //var newPhoto1 = App.Mapper.Map<Data.Tables.Photo>(photo1);
            //var newPhoto2 = App.Mapper.Map<Data.Tables.Photo>(photo2);
            //var newPhoto3 = App.Mapper.Map<Data.Tables.Photo>(photo3);
            //var newPhoto4 = App.Mapper.Map<Data.Tables.Photo>(photo4);
            //var newPhoto5 = App.Mapper.Map<Data.Tables.Photo>(photo5);

            //await App.Photos.AddPhoto(newPhoto1);
            //await App.Photos.AddPhoto(newPhoto2);
            //await App.Photos.AddPhoto(newPhoto3);
            //await App.Photos.AddPhoto(newPhoto4);
            //await App.Photos.AddPhoto(newPhoto5);
        }
    }
}
