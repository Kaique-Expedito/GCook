using GCook.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace GCook.Services;

public interface IUsuarioService
{   
    Task<SignInResult> LoginUsuario(LoginVM login);
    Task LogoutUsuario();
}

