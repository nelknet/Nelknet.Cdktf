namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServicequotasServiceState<'ServiceName> = { assignments: ResizeArray<aws.DataAwsServicequotasService.DataAwsServicequotasServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicequotas_service">aws_servicequotas_service</a>.
    /// </summary>
    type DataAwsServicequotasServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServicequotasServiceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicequotasServiceState<Missing>)

        member _.Zero(()) : DataAwsServicequotasServiceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServicequotasServiceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicequotas_service#service_name-1">DataAwsServicequotasService#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: DataAwsServicequotasServiceState<Missing>, value: string) : DataAwsServicequotasServiceState<Present> =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            ({ assignments = state.assignments } : DataAwsServicequotasServiceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicequotas_service#id-1">DataAwsServicequotasService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServicequotasServiceState<'ServiceName>, value: string) : DataAwsServicequotasServiceState<'ServiceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsServicequotasServiceState<'ServiceName>

        member _.Run(state: DataAwsServicequotasServiceState<Present>) : aws.DataAwsServicequotasService.DataAwsServicequotasService =
            let config = aws.DataAwsServicequotasService.DataAwsServicequotasServiceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServicequotasService.DataAwsServicequotasService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServicequotasService: missing required arguments. Must call: service_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServicequotasServiceState<_>) : aws.DataAwsServicequotasService.DataAwsServicequotasService =
            Unchecked.defaultof<aws.DataAwsServicequotasService.DataAwsServicequotasService>
