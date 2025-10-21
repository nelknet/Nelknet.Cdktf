namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServicePrincipalState<'ServiceName> = { assignments: ResizeArray<aws.DataAwsServicePrincipal.DataAwsServicePrincipalConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_principal">aws_service_principal</a>.
    /// </summary>
    type DataAwsServicePrincipalBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServicePrincipalState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicePrincipalState<Missing>)

        member _.Zero(()) : DataAwsServicePrincipalState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicePrincipalState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_principal#service_name-1">DataAwsServicePrincipal#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: DataAwsServicePrincipalState<Missing>, value: string) : DataAwsServicePrincipalState<Present> =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            ({ assignments = state.assignments } : DataAwsServicePrincipalState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service_principal#region-1">DataAwsServicePrincipal#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: DataAwsServicePrincipalState<'ServiceName>, value: string) : DataAwsServicePrincipalState<'ServiceName> =
            state.assignments.Add(fun config -> config.Region <- value)
            state : DataAwsServicePrincipalState<'ServiceName>

        member _.Run(state: DataAwsServicePrincipalState<Present>) : aws.DataAwsServicePrincipal.DataAwsServicePrincipal =
            let config = aws.DataAwsServicePrincipal.DataAwsServicePrincipalConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServicePrincipal.DataAwsServicePrincipal(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServicePrincipal: missing required arguments. Must call: service_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServicePrincipalState<_>) : aws.DataAwsServicePrincipal.DataAwsServicePrincipal =
            Unchecked.defaultof<aws.DataAwsServicePrincipal.DataAwsServicePrincipal>
