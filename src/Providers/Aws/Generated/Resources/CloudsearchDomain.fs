namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudsearchDomainState<'Name> = { assignments: ResizeArray<aws.CloudsearchDomain.CloudsearchDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain">aws_cloudsearch_domain</a>.
    /// </summary>
    type CloudsearchDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudsearchDomainState<Missing> =
            ({ assignments = ResizeArray() } : CloudsearchDomainState<Missing>)

        member _.Zero(()) : CloudsearchDomainState<Missing> =
            ({ assignments = ResizeArray() } : CloudsearchDomainState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#name-1">CloudsearchDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudsearchDomainState<Missing>, value: string) : CloudsearchDomainState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudsearchDomainState<Present>)

        /// <summary>
        /// endpoint_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#endpoint_options-1">CloudsearchDomain#endpoint_options</a>
        /// </summary>
        [<CustomOperation "endpoint_options">]
        member _.EndpointOptions(state: CloudsearchDomainState<'Name>, value: aws.CloudsearchDomain.CloudsearchDomainEndpointOptions) : CloudsearchDomainState<'Name> =
            state.assignments.Add(fun config -> config.EndpointOptions <- value)
            state : CloudsearchDomainState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#id-1">CloudsearchDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudsearchDomainState<'Name>, value: string) : CloudsearchDomainState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudsearchDomainState<'Name>

        /// <summary>
        /// index_field block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#index_field-1">CloudsearchDomain#index_field</a> Accepts: aws.IResolvable | aws.CloudsearchDomain.CloudsearchDomainIndexField[]
        /// </summary>
        [<CustomOperation "index_field">]
        member _.IndexField(state: CloudsearchDomainState<'Name>, value: HashiCorp.Cdktf.IResolvable) : CloudsearchDomainState<'Name> =
            state.assignments.Add(fun config -> config.IndexField <- value)
            state : CloudsearchDomainState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#multi_az-1">CloudsearchDomain#multi_az</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_az">]
        member _.MultiAz(state: CloudsearchDomainState<'Name>, value: bool) : CloudsearchDomainState<'Name> =
            state.assignments.Add(fun config -> config.MultiAz <- value)
            state : CloudsearchDomainState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#multi_az-1">CloudsearchDomain#multi_az</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_az">]
        member _.MultiAz(state: CloudsearchDomainState<'Name>, value: HashiCorp.Cdktf.IResolvable) : CloudsearchDomainState<'Name> =
            state.assignments.Add(fun config -> config.MultiAz <- value)
            state : CloudsearchDomainState<'Name>

        /// <summary>
        /// scaling_parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#scaling_parameters-1">CloudsearchDomain#scaling_parameters</a>
        /// </summary>
        [<CustomOperation "scaling_parameters">]
        member _.ScalingParameters(state: CloudsearchDomainState<'Name>, value: aws.CloudsearchDomain.CloudsearchDomainScalingParameters) : CloudsearchDomainState<'Name> =
            state.assignments.Add(fun config -> config.ScalingParameters <- value)
            state : CloudsearchDomainState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudsearch_domain#timeouts-1">CloudsearchDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CloudsearchDomainState<'Name>, value: aws.CloudsearchDomain.CloudsearchDomainTimeouts) : CloudsearchDomainState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CloudsearchDomainState<'Name>

        member _.Run(state: CloudsearchDomainState<Present>) : aws.CloudsearchDomain.CloudsearchDomain =
            let config = aws.CloudsearchDomain.CloudsearchDomainConfig()
            for setter in state.assignments do
                setter config
            aws.CloudsearchDomain.CloudsearchDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudsearchDomain: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: CloudsearchDomainState<_>) : aws.CloudsearchDomain.CloudsearchDomain =
            Unchecked.defaultof<aws.CloudsearchDomain.CloudsearchDomain>
