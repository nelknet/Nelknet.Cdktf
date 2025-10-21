namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GuarddutyDetectorState = { assignments: ResizeArray<aws.GuarddutyDetector.GuarddutyDetectorConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector">aws_guardduty_detector</a>.
    /// </summary>
    type GuarddutyDetectorBuilder(logicalId: string) =
        member _.Yield(_: unit) : GuarddutyDetectorState =
            { assignments = ResizeArray() }

        member _.Zero(()) : GuarddutyDetectorState =
            { assignments = ResizeArray() }

        /// <summary>
        /// datasources block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#datasources-1">GuarddutyDetector#datasources</a>
        /// </summary>
        [<CustomOperation "datasources">]
        member _.Datasources(state: GuarddutyDetectorState, value: aws.GuarddutyDetector.GuarddutyDetectorDatasources) : GuarddutyDetectorState =
            state.assignments.Add(fun config -> config.Datasources <- value)
            state : GuarddutyDetectorState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#enable-1">GuarddutyDetector#enable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable">]
        member _.Enable(state: GuarddutyDetectorState, value: bool) : GuarddutyDetectorState =
            state.assignments.Add(fun config -> config.Enable <- value)
            state : GuarddutyDetectorState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#enable-1">GuarddutyDetector#enable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable">]
        member _.Enable(state: GuarddutyDetectorState, value: HashiCorp.Cdktf.IResolvable) : GuarddutyDetectorState =
            state.assignments.Add(fun config -> config.Enable <- value)
            state : GuarddutyDetectorState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#finding_publishing_frequency-1">GuarddutyDetector#finding_publishing_frequency</a>.
        /// </summary>
        [<CustomOperation "finding_publishing_frequency">]
        member _.FindingPublishingFrequency(state: GuarddutyDetectorState, value: string) : GuarddutyDetectorState =
            state.assignments.Add(fun config -> config.FindingPublishingFrequency <- value)
            state : GuarddutyDetectorState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#id-1">GuarddutyDetector#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GuarddutyDetectorState, value: string) : GuarddutyDetectorState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GuarddutyDetectorState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#tags-1">GuarddutyDetector#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GuarddutyDetectorState, value: seq<string * string>) : GuarddutyDetectorState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GuarddutyDetectorState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_detector#tags_all-1">GuarddutyDetector#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GuarddutyDetectorState, value: seq<string * string>) : GuarddutyDetectorState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GuarddutyDetectorState

        member _.Run(state: GuarddutyDetectorState) : aws.GuarddutyDetector.GuarddutyDetector =
            let config = aws.GuarddutyDetector.GuarddutyDetectorConfig()
            for setter in state.assignments do
                setter config
            aws.GuarddutyDetector.GuarddutyDetector(StackContext.get (), logicalId, config)
