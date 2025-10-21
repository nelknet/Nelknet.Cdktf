namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEbsVolumesState = { assignments: ResizeArray<aws.DataAwsEbsVolumes.DataAwsEbsVolumesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volumes">aws_ebs_volumes</a>.
    /// </summary>
    type DataAwsEbsVolumesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEbsVolumesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEbsVolumesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volumes#filter-1">DataAwsEbsVolumes#filter</a> Accepts: aws.IResolvable | aws.DataAwsEbsVolumes.DataAwsEbsVolumesFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsEbsVolumesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsEbsVolumesState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsEbsVolumesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volumes#id-1">DataAwsEbsVolumes#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEbsVolumesState, value: string) : DataAwsEbsVolumesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEbsVolumesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volumes#tags-1">DataAwsEbsVolumes#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEbsVolumesState, value: seq<string * string>) : DataAwsEbsVolumesState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEbsVolumesState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volumes#timeouts-1">DataAwsEbsVolumes#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsEbsVolumesState, value: aws.DataAwsEbsVolumes.DataAwsEbsVolumesTimeouts) : DataAwsEbsVolumesState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsEbsVolumesState

        member _.Run(state: DataAwsEbsVolumesState) : aws.DataAwsEbsVolumes.DataAwsEbsVolumes =
            let config = aws.DataAwsEbsVolumes.DataAwsEbsVolumesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEbsVolumes.DataAwsEbsVolumes(StackContext.get (), logicalId, config)
