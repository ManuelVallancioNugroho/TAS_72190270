using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFrontEnd.Models;
using BlazorFrontEnd.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorFrontEnd.Pages
{
    public partial class DeleteStudent
      {
            [Parameter]
          public string Id { get; set; }

             [Inject]
          public IStudentService StudentService { get; set; }

            [Inject]
          public NavigationManager NavigationManager { get; set; }
           protected async override Task OnInitializedAsync()
        {
            await StudentService.Delete(int.Parse(Id));
            NavigationManager.NavigateTo("/studentpage");
        }

      }
}