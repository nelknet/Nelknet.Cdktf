namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamSecurityTokenServicePreferencesState<'GlobalEndpointTokenVersion> = { assignments: ResizeArray<aws.IamSecurityTokenServicePreferences.IamSecurityTokenServicePreferencesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_security_token_service_preferences">aws_iam_security_token_service_preferences</a>.
    /// </summary>
    type IamSecurityTokenServicePreferencesBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamSecurityTokenServicePreferencesState<Missing> =
            ({ assignments = ResizeArray() } : IamSecurityTokenServicePreferencesState<Missing>)

        member _.Zero(()) : IamSecurityTokenServicePreferencesState<Missing> =
            ({ assignments = ResizeArray() } : IamSecurityTokenServicePreferencesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_security_token_service_preferences#global_endpoint_token_version-1">IamSecurityTokenServicePreferences#global_endpoint_token_version</a>.
        /// </summary>
        [<CustomOperation "global_endpoint_token_version">]
        member _.GlobalEndpointTokenVersion(state: IamSecurityTokenServicePreferencesState<Missing>, value: string) : IamSecurityTokenServicePreferencesState<Present> =
            state.assignments.Add(fun config -> config.GlobalEndpointTokenVersion <- value)
            ({ assignments = state.assignments } : IamSecurityTokenServicePreferencesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_security_token_service_preferences#id-1">IamSecurityTokenServicePreferences#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamSecurityTokenServicePreferencesState<'GlobalEndpointTokenVersion>, value: string) : IamSecurityTokenServicePreferencesState<'GlobalEndpointTokenVersion> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamSecurityTokenServicePreferencesState<'GlobalEndpointTokenVersion>

        member _.Run(state: IamSecurityTokenServicePreferencesState<Present>) : aws.IamSecurityTokenServicePreferences.IamSecurityTokenServicePreferences =
            let config = aws.IamSecurityTokenServicePreferences.IamSecurityTokenServicePreferencesConfig()
            for setter in state.assignments do
                setter config
            aws.IamSecurityTokenServicePreferences.IamSecurityTokenServicePreferences(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamSecurityTokenServicePreferences: missing required arguments. Must call: global_endpoint_token_version.", 9999, IsError = true)>]
        member _.Run(_: IamSecurityTokenServicePreferencesState<_>) : aws.IamSecurityTokenServicePreferences.IamSecurityTokenServicePreferences =
            Unchecked.defaultof<aws.IamSecurityTokenServicePreferences.IamSecurityTokenServicePreferences>
