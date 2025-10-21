namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOpensearchDomainState<'DomainName> = { assignments: ResizeArray<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearch_domain">aws_opensearch_domain</a>.
    /// </summary>
    type DataAwsOpensearchDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOpensearchDomainState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOpensearchDomainState<Missing>)

        member _.Zero(()) : DataAwsOpensearchDomainState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOpensearchDomainState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearch_domain#domain_name-1">DataAwsOpensearchDomain#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: DataAwsOpensearchDomainState<Missing>, value: string) : DataAwsOpensearchDomainState<Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : DataAwsOpensearchDomainState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearch_domain#id-1">DataAwsOpensearchDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOpensearchDomainState<'DomainName>, value: string) : DataAwsOpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOpensearchDomainState<'DomainName>

        /// <summary>
        /// off_peak_window_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearch_domain#off_peak_window_options-1">DataAwsOpensearchDomain#off_peak_window_options</a>
        /// </summary>
        [<CustomOperation "off_peak_window_options">]
        member _.OffPeakWindowOptions(state: DataAwsOpensearchDomainState<'DomainName>, value: aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainOffPeakWindowOptions) : DataAwsOpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.OffPeakWindowOptions <- value)
            state : DataAwsOpensearchDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearch_domain#tags-1">DataAwsOpensearchDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsOpensearchDomainState<'DomainName>, value: seq<string * string>) : DataAwsOpensearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsOpensearchDomainState<'DomainName>

        member _.Run(state: DataAwsOpensearchDomainState<Present>) : aws.DataAwsOpensearchDomain.DataAwsOpensearchDomain =
            let config = aws.DataAwsOpensearchDomain.DataAwsOpensearchDomainConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOpensearchDomain.DataAwsOpensearchDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOpensearchDomain: missing required arguments. Must call: domain_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOpensearchDomainState<_>) : aws.DataAwsOpensearchDomain.DataAwsOpensearchDomain =
            Unchecked.defaultof<aws.DataAwsOpensearchDomain.DataAwsOpensearchDomain>
