using System.Drawing;

int clothingID_1 = 1;
string clothingType1 = "T-Shirt";
string clothingSize_1 = "XXL";
string clothingBrand_1 = "EtBrand";
int clothingCondition_1 = 0;
string clothingMaterial_1 = "Asbest";
double clothingCo2 = 0;
bool clothingIsSold = false;
DateTime clothingSoldDate = DateTime.Now;

int clothingID_2 = 1;
string clothingType_2 = "Slips";
string clothingSize_2 = "L";
string clothingBrand_2 = "2Brand";
int clothingCondition_2 = 1;
string clothingMaterial_2 = "Silke";
double clothingCo2_2 = 0;
bool clothingIsSold_2 = false;
DateTime clothingSoldDate_2 = DateTime.Now;

int clothingID_3 = 1;
string clothingType_3 = "Bukser";
string clothingSize_3 = "S";
string clothingBrand_3 = "3Brand";
int clothingCondition_3 = 2;
string clothingMaterial_3 = "Bomuld";
double clothingCo2_3 = 0;
bool clothingIsSold_3 = false;
DateTime clothingSoldDate_3 = DateTime.Now;

List<string> clothingTypes = new List<string>() { clothingType1, clothingType_2, clothingType_3};
List<string> clothingSizes = new List<string>() { clothingSize_1, clothingSize_2, clothingSize_3};
List<string> clothingBrands = new List<string>() { clothingBrand_1, clothingBrand_2, clothingBrand_3};
List<string> clothingMaterials = new List<string>() { clothingMaterial_1, clothingMaterial_2, clothingMaterial_3};
List<int> clothingConditions = new List<int> { clothingCondition_1, clothingCondition_2, clothingCondition_3};
List<double> clothingCo2s = new List<double>() { clothingCo2, clothingCo2_2, clothingCo2_3};
List<bool> clothingIsSolds = new List<bool>() { clothingIsSold, clothingIsSold_2, clothingIsSold_3};
List<int> clothingIDs = new List<int>() {clothingID_1, clothingID_2, clothingID_3};
List<DateTime> clothingSoldDates = new List<DateTime>() {clothingSoldDate, clothingSoldDate_2, clothingSoldDate_3};

void addItem( int ID, string type, string size, string brand, int condition, string material, double co2, bool isSold, DateTime soldDate)
{
    clothingIDs.Add(ID);
    clothingTypes.Add(type);
    clothingSizes.Add(size);
    clothingBrands.Add(brand);
    clothingConditions.Add(condition);
    clothingMaterials.Add(material);
    clothingCo2s.Add(co2);
    clothingIsSolds.Add(isSold);
    clothingSoldDates.Add(soldDate);
}

foreach (var Item in clothingIDs)
{
    Console.WriteLine($"Clothing Item: {Item}");
    Console.WriteLine($"Clothing Type: {clothingTypes[Item]}");
    Console.WriteLine($"Clothing Size: {clothingSizes[Item]}");
    Console.WriteLine($"Clothing Brand: {clothingBrands[Item]}");
    Console.WriteLine($"Clothing Condition: {clothingConditions[Item]}");
    Console.WriteLine($"Clothing Materials: {clothingMaterials[Item]}");
    Console.WriteLine($"Co2 Savings: {clothingCo2s[Item]}");
    Console.WriteLine($"Is Item Sold: {clothingIsSolds[Item]}");
    Console.WriteLine($"Clothing Sold: {clothingSoldDates[Item]}");
}

// Help 












