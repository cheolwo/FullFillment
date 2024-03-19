using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 주문FrontCommon
{
    public class 로그인ViewModel : ObservableObject
    {
        private HttpClient _httpClient;
        public 로그인ViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}
