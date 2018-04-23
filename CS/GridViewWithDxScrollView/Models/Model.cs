using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GridViewWithDxScrollView.Models {
    public static class ModelRepository {
        public static List<Model> GetData() {
            Random rnd = new Random();
            return Enumerable.Range(1, 50).Select(i => new Model {
                ID = Guid.NewGuid(),
                Text = "Text " + i,
                Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                Price = i * rnd.NextDouble()
            }).ToList<Model>();
        }
    }
    public class Model {
        public Guid ID { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}