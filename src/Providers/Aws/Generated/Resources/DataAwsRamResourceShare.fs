namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRamResourceShareState<'ResourceOwner> = { assignments: ResizeArray<aws.DataAwsRamResourceShare.DataAwsRamResourceShareConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ram_resource_share">aws_ram_resource_share</a>.
    /// </summary>
    type DataAwsRamResourceShareBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRamResourceShareState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRamResourceShareState<Missing>)

        member _.Zero(()) : DataAwsRamResourceShareState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRamResourceShareState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ram_resource_share#resource_owner-1">DataAwsRamResourceShare#resource_owner</a>.
        /// </summary>
        [<CustomOperation "resource_owner">]
        member _.ResourceOwner(state: DataAwsRamResourceShareState<Missing>, value: string) : DataAwsRamResourceShareState<Present> =
            state.assignments.Add(fun config -> config.ResourceOwner <- value)
            ({ assignments = state.assignments } : DataAwsRamResourceShareState<Present>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ram_resource_share#filter-1">DataAwsRamResourceShare#filter</a> Accepts: aws.IResolvable | aws.DataAwsRamResourceShare.DataAwsRamResourceShareFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsRamResourceShareState<'ResourceOwner>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRamResourceShareState<'ResourceOwner> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsRamResourceShareState<'ResourceOwner>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ram_resource_share#id-1">DataAwsRamResourceShare#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRamResourceShareState<'ResourceOwner>, value: string) : DataAwsRamResourceShareState<'ResourceOwner> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRamResourceShareState<'ResourceOwner>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ram_resource_share#name-1">DataAwsRamResourceShare#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsRamResourceShareState<'ResourceOwner>, value: string) : DataAwsRamResourceShareState<'ResourceOwner> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsRamResourceShareState<'ResourceOwner>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ram_resource_share#resource_share_status-1">DataAwsRamResourceShare#resource_share_status</a>.
        /// </summary>
        [<CustomOperation "resource_share_status">]
        member _.ResourceShareStatus(state: DataAwsRamResourceShareState<'ResourceOwner>, value: string) : DataAwsRamResourceShareState<'ResourceOwner> =
            state.assignments.Add(fun config -> config.ResourceShareStatus <- value)
            state : DataAwsRamResourceShareState<'ResourceOwner>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ram_resource_share#tags-1">DataAwsRamResourceShare#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsRamResourceShareState<'ResourceOwner>, value: seq<string * string>) : DataAwsRamResourceShareState<'ResourceOwner> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsRamResourceShareState<'ResourceOwner>

        member _.Run(state: DataAwsRamResourceShareState<Present>) : aws.DataAwsRamResourceShare.DataAwsRamResourceShare =
            let config = aws.DataAwsRamResourceShare.DataAwsRamResourceShareConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRamResourceShare.DataAwsRamResourceShare(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRamResourceShare: missing required arguments. Must call: resource_owner.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRamResourceShareState<_>) : aws.DataAwsRamResourceShare.DataAwsRamResourceShare =
            Unchecked.defaultof<aws.DataAwsRamResourceShare.DataAwsRamResourceShare>
