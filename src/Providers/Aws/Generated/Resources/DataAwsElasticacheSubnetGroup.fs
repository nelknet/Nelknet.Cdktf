namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsElasticacheSubnetGroupState<'Name> = { assignments: ResizeArray<aws.DataAwsElasticacheSubnetGroup.DataAwsElasticacheSubnetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_subnet_group">aws_elasticache_subnet_group</a>.
    /// </summary>
    type DataAwsElasticacheSubnetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsElasticacheSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticacheSubnetGroupState<Missing>)

        member _.Zero(()) : DataAwsElasticacheSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsElasticacheSubnetGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_subnet_group#name-1">DataAwsElasticacheSubnetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsElasticacheSubnetGroupState<Missing>, value: string) : DataAwsElasticacheSubnetGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsElasticacheSubnetGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_subnet_group#id-1">DataAwsElasticacheSubnetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsElasticacheSubnetGroupState<'Name>, value: string) : DataAwsElasticacheSubnetGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsElasticacheSubnetGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_subnet_group#tags-1">DataAwsElasticacheSubnetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsElasticacheSubnetGroupState<'Name>, value: seq<string * string>) : DataAwsElasticacheSubnetGroupState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsElasticacheSubnetGroupState<'Name>

        member _.Run(state: DataAwsElasticacheSubnetGroupState<Present>) : aws.DataAwsElasticacheSubnetGroup.DataAwsElasticacheSubnetGroup =
            let config = aws.DataAwsElasticacheSubnetGroup.DataAwsElasticacheSubnetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsElasticacheSubnetGroup.DataAwsElasticacheSubnetGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsElasticacheSubnetGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsElasticacheSubnetGroupState<_>) : aws.DataAwsElasticacheSubnetGroup.DataAwsElasticacheSubnetGroup =
            Unchecked.defaultof<aws.DataAwsElasticacheSubnetGroup.DataAwsElasticacheSubnetGroup>
