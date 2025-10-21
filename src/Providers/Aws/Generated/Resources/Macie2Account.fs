namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Macie2AccountState = { assignments: ResizeArray<aws.Macie2Account.Macie2AccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_account">aws_macie2_account</a>.
    /// </summary>
    type Macie2AccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : Macie2AccountState =
            { assignments = ResizeArray() }

        member _.Zero(()) : Macie2AccountState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_account#finding_publishing_frequency-1">Macie2Account#finding_publishing_frequency</a>.
        /// </summary>
        [<CustomOperation "finding_publishing_frequency">]
        member _.FindingPublishingFrequency(state: Macie2AccountState, value: string) : Macie2AccountState =
            state.assignments.Add(fun config -> config.FindingPublishingFrequency <- value)
            state : Macie2AccountState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_account#id-1">Macie2Account#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Macie2AccountState, value: string) : Macie2AccountState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Macie2AccountState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_account#status-1">Macie2Account#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: Macie2AccountState, value: string) : Macie2AccountState =
            state.assignments.Add(fun config -> config.Status <- value)
            state : Macie2AccountState

        member _.Run(state: Macie2AccountState) : aws.Macie2Account.Macie2Account =
            let config = aws.Macie2Account.Macie2AccountConfig()
            for setter in state.assignments do
                setter config
            aws.Macie2Account.Macie2Account(StackContext.get (), logicalId, config)
