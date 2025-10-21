namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsElasticsearchDomainState<'DomainName> = { assignments: ResizeArray<aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticsearch_domain">aws_elasticsearch_domain</a>.
    /// </summary>
    type DataAwsElasticsearchDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsElasticsearchDomainState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticsearchDomainState<Missing>)

        member _.Zero(()) : DataAwsElasticsearchDomainState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticsearchDomainState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticsearch_domain#domain_name-1">DataAwsElasticsearchDomain#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: DataAwsElasticsearchDomainState<Missing>, value: string) : DataAwsElasticsearchDomainState<Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : DataAwsElasticsearchDomainState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticsearch_domain#id-1">DataAwsElasticsearchDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsElasticsearchDomainState<'DomainName>, value: string) : DataAwsElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsElasticsearchDomainState<'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticsearch_domain#tags-1">DataAwsElasticsearchDomain#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsElasticsearchDomainState<'DomainName>, value: seq<string * string>) : DataAwsElasticsearchDomainState<'DomainName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsElasticsearchDomainState<'DomainName>

        member _.Run(state: DataAwsElasticsearchDomainState<Present>) : aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomain =
            let config = aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomainConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsElasticsearchDomain: missing required arguments. Must call: domain_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsElasticsearchDomainState<_>) : aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomain =
            Unchecked.defaultof<aws.DataAwsElasticsearchDomain.DataAwsElasticsearchDomain>
