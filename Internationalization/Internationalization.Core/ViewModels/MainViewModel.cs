﻿using MvvmCross.Core.ViewModels;
using MvvmCross.Localization;
using MvvmCross.Plugins.JsonLocalization;

namespace Internationalization.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxTextProviderBuilder _builder;

        public MainViewModel(IMvxTextProviderBuilder builder)
        {
            _builder = builder;
            _builder.LoadResources("en");
        }

        public IMvxLanguageBinder TextSource
        {
            get { return new MvxLanguageBinder(Constants.GeneralNamespace, GetType().Name); }
        }
    }
}