namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsVpcEndpointServiceState = { assignments: ResizeArray<aws.DataAwsVpcEndpointService.DataAwsVpcEndpointServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint_service">aws_vpc_endpoint_service</a>.
    /// </summary>
    type DataAwsVpcEndpointServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsVpcEndpointServiceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsVpcEndpointServiceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint_service#filter-1">DataAwsVpcEndpointService#filter</a> Accepts: aws.IResolvable | aws.DataAwsVpcEndpointService.DataAwsVpcEndpointServiceFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsVpcEndpointServiceState, value: HashiCorp.Cdktf.IResolvable) : DataAwsVpcEndpointServiceState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsVpcEndpointServiceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint_service#id-1">DataAwsVpcEndpointService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsVpcEndpointServiceState, value: string) : DataAwsVpcEndpointServiceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsVpcEndpointServiceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint_service#service-1">DataAwsVpcEndpointService#service</a>.
        /// </summary>
        [<CustomOperation "service">]
        member _.Service(state: DataAwsVpcEndpointServiceState, value: string) : DataAwsVpcEndpointServiceState =
            state.assignments.Add(fun config -> config.Service <- value)
            state : DataAwsVpcEndpointServiceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint_service#service_name-1">DataAwsVpcEndpointService#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: DataAwsVpcEndpointServiceState, value: string) : DataAwsVpcEndpointServiceState =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            state : DataAwsVpcEndpointServiceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint_service#service_regions-1">DataAwsVpcEndpointService#service_regions</a>.
        /// </summary>
        [<CustomOperation "service_regions">]
        member _.ServiceRegions(state: DataAwsVpcEndpointServiceState, value: seq<string>) : DataAwsVpcEndpointServiceState =
            state.assignments.Add(fun config -> config.ServiceRegions <- (value |> Seq.toArray))
            state : DataAwsVpcEndpointServiceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint_service#service_type-1">DataAwsVpcEndpointService#service_type</a>.
        /// </summary>
        [<CustomOperation "service_type">]
        member _.ServiceType(state: DataAwsVpcEndpointServiceState, value: string) : DataAwsVpcEndpointServiceState =
            state.assignments.Add(fun config -> config.ServiceType <- value)
            state : DataAwsVpcEndpointServiceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint_service#tags-1">DataAwsVpcEndpointService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsVpcEndpointServiceState, value: seq<string * string>) : DataAwsVpcEndpointServiceState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsVpcEndpointServiceState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint_service#timeouts-1">DataAwsVpcEndpointService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsVpcEndpointServiceState, value: aws.DataAwsVpcEndpointService.DataAwsVpcEndpointServiceTimeouts) : DataAwsVpcEndpointServiceState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsVpcEndpointServiceState

        member _.Run(state: DataAwsVpcEndpointServiceState) : aws.DataAwsVpcEndpointService.DataAwsVpcEndpointService =
            let config = aws.DataAwsVpcEndpointService.DataAwsVpcEndpointServiceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsVpcEndpointService.DataAwsVpcEndpointService(StackContext.get (), logicalId, config)
