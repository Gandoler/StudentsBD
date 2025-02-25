using BDAPP.logic.AppSettingsParse.Templaetes;

namespace BDAPP.logic.AppSettingsParse.Reader
{
    internal interface IJsonReaderForConfig
    {
        T Read<T>(string filePath) where T : ITemplates;
    }
}
