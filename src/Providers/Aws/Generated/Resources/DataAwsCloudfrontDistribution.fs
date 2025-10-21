namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCloudfrontDistributionState<'Id> = { assignments: ResizeArray<aws.DataAwsCloudfrontDistribution.DataAwsCloudfrontDistributionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_distribution">aws_cloudfront_distribution</a>.
    /// </summary>
    type DataAwsCloudfrontDistributionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCloudfrontDistributionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudfrontDistributionState<Missing>)

        member _.Zero(()) : DataAwsCloudfrontDistributionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCloudfrontDistributionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_distribution#id-1">DataAwsCloudfrontDistribution#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCloudfrontDistributionState<Missing>, value: string) : DataAwsCloudfrontDistributionState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsCloudfrontDistributionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cloudfront_distribution#tags-1">DataAwsCloudfrontDistribution#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsCloudfrontDistributionState<'Id>, value: seq<string * string>) : DataAwsCloudfrontDistributionState<'Id> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsCloudfrontDistributionState<'Id>

        member _.Run(state: DataAwsCloudfrontDistributionState<Present>) : aws.DataAwsCloudfrontDistribution.DataAwsCloudfrontDistribution =
            let config = aws.DataAwsCloudfrontDistribution.DataAwsCloudfrontDistributionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCloudfrontDistribution.DataAwsCloudfrontDistribution(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCloudfrontDistribution: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCloudfrontDistributionState<_>) : aws.DataAwsCloudfrontDistribution.DataAwsCloudfrontDistribution =
            Unchecked.defaultof<aws.DataAwsCloudfrontDistribution.DataAwsCloudfrontDistribution>
