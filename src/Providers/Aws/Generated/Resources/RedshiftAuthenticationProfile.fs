namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftAuthenticationProfileState<'AuthenticationProfileContent, 'AuthenticationProfileName> = { assignments: ResizeArray<aws.RedshiftAuthenticationProfile.RedshiftAuthenticationProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_authentication_profile">aws_redshift_authentication_profile</a>.
    /// </summary>
    type RedshiftAuthenticationProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftAuthenticationProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftAuthenticationProfileState<Missing, Missing>)

        member _.Zero(()) : RedshiftAuthenticationProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftAuthenticationProfileState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_authentication_profile#authentication_profile_content-1">RedshiftAuthenticationProfile#authentication_profile_content</a>.
        /// </summary>
        [<CustomOperation "authentication_profile_content">]
        member _.AuthenticationProfileContent(state: RedshiftAuthenticationProfileState<Missing, 'AuthenticationProfileName>, value: string) : RedshiftAuthenticationProfileState<Present, 'AuthenticationProfileName> =
            state.assignments.Add(fun config -> config.AuthenticationProfileContent <- value)
            ({ assignments = state.assignments } : RedshiftAuthenticationProfileState<Present, 'AuthenticationProfileName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_authentication_profile#authentication_profile_name-1">RedshiftAuthenticationProfile#authentication_profile_name</a>.
        /// </summary>
        [<CustomOperation "authentication_profile_name">]
        member _.AuthenticationProfileName(state: RedshiftAuthenticationProfileState<'AuthenticationProfileContent, Missing>, value: string) : RedshiftAuthenticationProfileState<'AuthenticationProfileContent, Present> =
            state.assignments.Add(fun config -> config.AuthenticationProfileName <- value)
            ({ assignments = state.assignments } : RedshiftAuthenticationProfileState<'AuthenticationProfileContent, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_authentication_profile#id-1">RedshiftAuthenticationProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftAuthenticationProfileState<'AuthenticationProfileContent, 'AuthenticationProfileName>, value: string) : RedshiftAuthenticationProfileState<'AuthenticationProfileContent, 'AuthenticationProfileName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftAuthenticationProfileState<'AuthenticationProfileContent, 'AuthenticationProfileName>

        member _.Run(state: RedshiftAuthenticationProfileState<Present, Present>) : aws.RedshiftAuthenticationProfile.RedshiftAuthenticationProfile =
            let config = aws.RedshiftAuthenticationProfile.RedshiftAuthenticationProfileConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftAuthenticationProfile.RedshiftAuthenticationProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftAuthenticationProfile: missing required arguments. Must call: authentication_profile_content, authentication_profile_name.", 9999, IsError = true)>]
        member _.Run(_: RedshiftAuthenticationProfileState<_, _>) : aws.RedshiftAuthenticationProfile.RedshiftAuthenticationProfile =
            Unchecked.defaultof<aws.RedshiftAuthenticationProfile.RedshiftAuthenticationProfile>
