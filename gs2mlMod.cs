using GMHooker;
using TSIMPH;
using UndertaleModLib;

namespace TSIMPH_API;

public class TSIMPH_API
{
    public void Load(int audiogroup, UndertaleData data)
    {
        if(audiogroup != 0){
            return;
        }
        
        // Here, you can modify the data however you want. Go nuts!
    }

    /*public void LateLoad(int audioGroup, UndertaleData data,)
    {
        if (audioGroup != 0) return;
        if (Conviences.SavePrefix == "")
        {
            data.Code.ByName("gml_Object_obj_persistent_Create_0").AppendGmlSafe(@"
                    global.saveprefix = """"
                ", data);
            return;
        }
        Conviences.AddSavePrefix("_");
        data.Strings.First(x => x.Content == "SaavoGame23-2.sav").Content = $"{Conviences.SavePrefix}SaavoGame23-2.sav";

        data.Strings.First(x => x.Content == "SaveFileBackup-").Content = $"{Conviences.SavePrefix}SaveFileBackup-";

        data.Strings.First(x => x.Content == "SaveFileBackup_alt_-").Content = $"{Conviences.SavePrefix}SaveFileBackup_alt_-";
        data.Code.ByName("gml_Object_obj_persistent_Create_0").AppendGmlSafe($@"
                    global.saveprefix = ""{Conviences.SavePrefix}""
            ", data);
    }*/


}
