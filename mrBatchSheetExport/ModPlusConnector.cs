﻿#pragma warning disable SA1600 // Elements should be documented
namespace mrBatchSheetExport
{
    using System.Collections.Generic;
    using ModPlusAPI.Interfaces;

    public class ModPlusConnector : IModPlusFunctionForRenga
    {
        private static ModPlusConnector _instance;

        public static ModPlusConnector Instance => _instance ?? (_instance = new ModPlusConnector());

        public SupportedProduct SupportedProduct => SupportedProduct.Renga;

        public string Name => "mrBatchSheetExport";

        public RengaProduct RengaProduct => RengaProduct.Any;

        public FunctionUILocation UiLocation => FunctionUILocation.PrimaryPanel;

        public ContextMenuShowCase ContextMenuShowCase => ContextMenuShowCase.Scene;

        public List<ViewType> ViewTypes => new List<ViewType>();

        public bool IsAddingToMenuBySelf => false;

        public string LName => "Пакетный экспорт листов";

        public string Description => "Функция позволяет экспортировать все указанные листы в dwg/dxf";

        public string Author => "Пекшев Александр aka Modis";

        public string Price => "0";

        public string FullDescription => string.Empty;
    }
}
#pragma warning restore SA1600 // Elements should be documented