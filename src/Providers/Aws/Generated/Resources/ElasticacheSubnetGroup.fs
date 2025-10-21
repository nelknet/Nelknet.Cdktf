namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticacheSubnetGroupState<'Name, 'SubnetIds> = { assignments: ResizeArray<aws.ElasticacheSubnetGroup.ElasticacheSubnetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_subnet_group">aws_elasticache_subnet_group</a>.
    /// </summary>
    type ElasticacheSubnetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticacheSubnetGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheSubnetGroupState<Missing, Missing>)

        member _.Zero(()) : ElasticacheSubnetGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticacheSubnetGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_subnet_group#name-1">ElasticacheSubnetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ElasticacheSubnetGroupState<Missing, 'SubnetIds>, value: string) : ElasticacheSubnetGroupState<Present, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ElasticacheSubnetGroupState<Present, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_subnet_group#subnet_ids-1">ElasticacheSubnetGroup#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: ElasticacheSubnetGroupState<'Name, Missing>, value: seq<string>) : ElasticacheSubnetGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ElasticacheSubnetGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_subnet_group#description-1">ElasticacheSubnetGroup#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ElasticacheSubnetGroupState<'Name, 'SubnetIds>, value: string) : ElasticacheSubnetGroupState<'Name, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ElasticacheSubnetGroupState<'Name, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_subnet_group#id-1">ElasticacheSubnetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticacheSubnetGroupState<'Name, 'SubnetIds>, value: string) : ElasticacheSubnetGroupState<'Name, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticacheSubnetGroupState<'Name, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_subnet_group#tags-1">ElasticacheSubnetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElasticacheSubnetGroupState<'Name, 'SubnetIds>, value: seq<string * string>) : ElasticacheSubnetGroupState<'Name, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElasticacheSubnetGroupState<'Name, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_subnet_group#tags_all-1">ElasticacheSubnetGroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ElasticacheSubnetGroupState<'Name, 'SubnetIds>, value: seq<string * string>) : ElasticacheSubnetGroupState<'Name, 'SubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ElasticacheSubnetGroupState<'Name, 'SubnetIds>

        member _.Run(state: ElasticacheSubnetGroupState<Present, Present>) : aws.ElasticacheSubnetGroup.ElasticacheSubnetGroup =
            let config = aws.ElasticacheSubnetGroup.ElasticacheSubnetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticacheSubnetGroup.ElasticacheSubnetGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticacheSubnetGroup: missing required arguments. Must call: name, subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: ElasticacheSubnetGroupState<_, _>) : aws.ElasticacheSubnetGroup.ElasticacheSubnetGroup =
            Unchecked.defaultof<aws.ElasticacheSubnetGroup.ElasticacheSubnetGroup>
