using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlCoMa.types
{
    public record CardMasterdata(
        string collectorNumber,
        string name_en,
        string name_fr,
        string faction,
        string rarity,
        string type,
        string handCost,
        string reserveCost,
        string forestPower,
        string mountainPower,
        string waterPower,
        string landmarksSize,
        string reserveSize,
        string abilities_en,
        string supportAbility_en,
        string abilities_fr,
        string supportAbility_fr,
        string id,
        string imagePath);
}
