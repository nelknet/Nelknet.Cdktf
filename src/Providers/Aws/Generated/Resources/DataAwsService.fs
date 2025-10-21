namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServiceState = { assignments: ResizeArray<aws.DataAwsService.DataAwsServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service">aws_service</a>.
    /// </summary>
    type DataAwsServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServiceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsServiceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service#dns_name-1">DataAwsService#dns_name</a>.
        /// </summary>
        [<CustomOperation "dns_name">]
        member _.DnsName(state: DataAwsServiceState, value: string) : DataAwsServiceState =
            state.assignments.Add(fun config -> config.DnsName <- value)
            state : DataAwsServiceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service#id-1">DataAwsService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServiceState, value: string) : DataAwsServiceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsServiceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service#region-1">DataAwsService#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: DataAwsServiceState, value: string) : DataAwsServiceState =
            state.assignments.Add(fun config -> config.Region <- value)
            state : DataAwsServiceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service#reverse_dns_name-1">DataAwsService#reverse_dns_name</a>.
        /// </summary>
        [<CustomOperation "reverse_dns_name">]
        member _.ReverseDnsName(state: DataAwsServiceState, value: string) : DataAwsServiceState =
            state.assignments.Add(fun config -> config.ReverseDnsName <- value)
            state : DataAwsServiceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service#reverse_dns_prefix-1">DataAwsService#reverse_dns_prefix</a>.
        /// </summary>
        [<CustomOperation "reverse_dns_prefix">]
        member _.ReverseDnsPrefix(state: DataAwsServiceState, value: string) : DataAwsServiceState =
            state.assignments.Add(fun config -> config.ReverseDnsPrefix <- value)
            state : DataAwsServiceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/service#service_id-1">DataAwsService#service_id</a>.
        /// </summary>
        [<CustomOperation "service_id">]
        member _.ServiceId(state: DataAwsServiceState, value: string) : DataAwsServiceState =
            state.assignments.Add(fun config -> config.ServiceId <- value)
            state : DataAwsServiceState

        member _.Run(state: DataAwsServiceState) : aws.DataAwsService.DataAwsService =
            let config = aws.DataAwsService.DataAwsServiceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsService.DataAwsService(StackContext.get (), logicalId, config)
