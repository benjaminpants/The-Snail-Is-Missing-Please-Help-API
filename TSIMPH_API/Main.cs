using GmmlPatcher;
using GmmlHooker;
using UndertaleModLib;
using UndertaleModLib.Models;
using System.Linq;
using System.Collections.Generic;
using System;
using WysApi.Api;
using System.IO;
using UndertaleModLib.Decompiler;
using System.Reflection;



namespace TSIMPH
{
    public class GameMakerMod : IGameMakerMod
    {
        public void Load(int audioGroup, UndertaleData data, ModData currentmod)
        {
            
        }

        public void LateLoad(int audioGroup, UndertaleData data, ModData currentmod)
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
        }

    }
}