using System.Collections.Generic;
using Abp;
using ProjectDemo.Chat.Dto;
using ProjectDemo.Dto;

namespace ProjectDemo.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
