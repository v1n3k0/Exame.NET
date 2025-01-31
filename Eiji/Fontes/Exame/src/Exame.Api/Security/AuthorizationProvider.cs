﻿using Microsoft.Owin.Security.OAuth;
using Microsoft.Practices.Unity;
using System;
using System.Threading.Tasks;

namespace Exame.Api.Security
{
    public class AuthorizationProvider : OAuthAuthorizationServerProvider
    {
        private readonly UnityContainer _container;

        public AuthorizationProvider(UnityContainer container)
        {
            _container = container;
        }

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            try
            {
                //IServiceJogador serviceJogador = _container.Resolve<IServiceJogador>();


                //AutenticarJogadorRequest request = new AutenticarJogadorRequest();
                //request.Email = context.UserName;
                //request.Senha = context.Password;

                //AutenticarJogadorResponse response = serviceJogador.AutenticarJogador(request);



                //if (serviceJogador.IsInvalid())
                //{
                //    if (response == null)
                //    {
                //        context.SetError("invalid_grant", "Preencha um e-mail válido e uma senha com pelo menos 6 caracteres.");
                //        return;
                //    }
                //}

                //serviceJogador.ClearNotifications();

                //if (response == null)
                //{
                //    context.SetError("invalid_grant", "Jogador não encontrado!");
                //    return;
                //}

                //var identity = new ClaimsIdentity(context.Options.AuthenticationType);

                ////Definindo as Claims
                //identity.AddClaim(new Claim("Jogador", JsonConvert.SerializeObject(response)));

                //var principal = new GenericPrincipal(identity, new string[] { });

                //Thread.CurrentPrincipal = principal;

                //context.Validated(identity);
            }
            catch (Exception ex)
            {
                context.SetError("invalid_grant", ex.Message);
                return;
            }
        }
    }
}