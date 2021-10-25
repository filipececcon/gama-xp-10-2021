using Gama.Locadora.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gama.Locadora.Comercial.Entities
{
    public class CarModel : Entity
    {
        public string Name { get; set; }
        public CarBrand Brand { get; set; }
        public Guid CarBrandId { get; set; }
    }
}


// INSERT INTO TB_CAR_MODEL (NAME, ID_BRAND) VALUES ('VW', 'sfg-sdfghdsfghdfh-fdghdfgh-')

// SELECT model.*, brand.* FROM TB_CAR_MODEL as model 
// INNER JOIN TB_CAR_BRAND as brand ON model.ID_BRAND = brand.ID
// WHERE ID = 'sdf-34532-fgsdfg-gsdfgsdfg'