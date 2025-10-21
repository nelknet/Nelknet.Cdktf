namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRedshiftSubnetGroupState<'Name> = { assignments: ResizeArray<aws.DataAwsRedshiftSubnetGroup.DataAwsRedshiftSubnetGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_subnet_group">aws_redshift_subnet_group</a>.
    /// </summary>
    type DataAwsRedshiftSubnetGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRedshiftSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRedshiftSubnetGroupState<Missing>)

        member _.Zero(()) : DataAwsRedshiftSubnetGroupState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRedshiftSubnetGroupState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_subnet_group#name-1">DataAwsRedshiftSubnetGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsRedshiftSubnetGroupState<Missing>, value: string) : DataAwsRedshiftSubnetGroupState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsRedshiftSubnetGroupState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_subnet_group#id-1">DataAwsRedshiftSubnetGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRedshiftSubnetGroupState<'Name>, value: string) : DataAwsRedshiftSubnetGroupState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRedshiftSubnetGroupState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshift_subnet_group#tags-1">DataAwsRedshiftSubnetGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsRedshiftSubnetGroupState<'Name>, value: seq<string * string>) : DataAwsRedshiftSubnetGroupState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsRedshiftSubnetGroupState<'Name>

        member _.Run(state: DataAwsRedshiftSubnetGroupState<Present>) : aws.DataAwsRedshiftSubnetGroup.DataAwsRedshiftSubnetGroup =
            let config = aws.DataAwsRedshiftSubnetGroup.DataAwsRedshiftSubnetGroupConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRedshiftSubnetGroup.DataAwsRedshiftSubnetGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRedshiftSubnetGroup: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRedshiftSubnetGroupState<_>) : aws.DataAwsRedshiftSubnetGroup.DataAwsRedshiftSubnetGroup =
            Unchecked.defaultof<aws.DataAwsRedshiftSubnetGroup.DataAwsRedshiftSubnetGroup>
