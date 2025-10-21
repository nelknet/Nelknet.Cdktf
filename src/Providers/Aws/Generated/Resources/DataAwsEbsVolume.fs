namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEbsVolumeState = { assignments: ResizeArray<aws.DataAwsEbsVolume.DataAwsEbsVolumeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volume">aws_ebs_volume</a>.
    /// </summary>
    type DataAwsEbsVolumeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEbsVolumeState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEbsVolumeState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volume#filter-1">DataAwsEbsVolume#filter</a> Accepts: aws.IResolvable | aws.DataAwsEbsVolume.DataAwsEbsVolumeFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEbsVolumeState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEbsVolumeState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEbsVolumeState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volume#id-1">DataAwsEbsVolume#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEbsVolumeState, value: string) : DataAwsEbsVolumeState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEbsVolumeState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volume#most_recent-1">DataAwsEbsVolume#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsEbsVolumeState, value: bool) : DataAwsEbsVolumeState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsEbsVolumeState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volume#most_recent-1">DataAwsEbsVolume#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsEbsVolumeState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEbsVolumeState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsEbsVolumeState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volume#tags-1">DataAwsEbsVolume#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEbsVolumeState, value: seq<string * string>) : DataAwsEbsVolumeState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEbsVolumeState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volume#timeouts-1">DataAwsEbsVolume#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEbsVolumeState, value: aws.DataAwsEbsVolume.DataAwsEbsVolumeTimeouts) : DataAwsEbsVolumeState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEbsVolumeState

        member _.Run(state: DataAwsEbsVolumeState) : aws.DataAwsEbsVolume.DataAwsEbsVolume =
            let config = aws.DataAwsEbsVolume.DataAwsEbsVolumeConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEbsVolume.DataAwsEbsVolume(StackContext.get (), logicalId, config)
