namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsGuarddutyDetectorState = { assignments: ResizeArray<aws.DataAwsGuarddutyDetector.DataAwsGuarddutyDetectorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/guardduty_detector">aws_guardduty_detector</a>.
    /// </summary>
    type DataAwsGuarddutyDetectorBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsGuarddutyDetectorState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsGuarddutyDetectorState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/guardduty_detector#id-1">DataAwsGuarddutyDetector#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsGuarddutyDetectorState, value: string) : DataAwsGuarddutyDetectorState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsGuarddutyDetectorState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/guardduty_detector#tags-1">DataAwsGuarddutyDetector#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsGuarddutyDetectorState, value: seq<string * string>) : DataAwsGuarddutyDetectorState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsGuarddutyDetectorState

        member _.Run(state: DataAwsGuarddutyDetectorState) : aws.DataAwsGuarddutyDetector.DataAwsGuarddutyDetector =
            let config = aws.DataAwsGuarddutyDetector.DataAwsGuarddutyDetectorConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsGuarddutyDetector.DataAwsGuarddutyDetector(StackContext.get (), logicalId, config)
