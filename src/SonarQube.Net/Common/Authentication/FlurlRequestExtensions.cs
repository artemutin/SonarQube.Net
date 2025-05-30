using System;
using Flurl.Http;

namespace SonarQube.Net.Common.Authentication
{
	public static class FlurlRequestExtensions
	{
		public static IFlurlRequest WithAuthentication(this IFlurlRequest request, AuthenticationMethod auth)
		{
			if (auth is BasicAuthentication basic)
			{
				return request.WithBasicAuth(basic.UserName, basic.Password);
			}else if (auth is BearerAuthentication bearer)
			{
				return request.WithOAuthBearerToken(bearer.Token);
			}

			throw new InvalidOperationException("Unknown authentication method");
		}
	}
}
