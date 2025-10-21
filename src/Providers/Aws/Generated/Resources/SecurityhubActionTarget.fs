namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubActionTargetState<'Description, 'Identifier, 'Name> = { assignments: ResizeArray<aws.SecurityhubActionTarget.SecurityhubActionTargetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_action_target">aws_securityhub_action_target</a>.
    /// </summary>
    type SecurityhubActionTargetBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubActionTargetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityhubActionTargetState<Missing, Missing, Missing>)

        member _.Zero(()) : SecurityhubActionTargetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityhubActionTargetState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_action_target#description-1">SecurityhubActionTarget#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SecurityhubActionTargetState<Missing, 'Identifier, 'Name>, value: string) : SecurityhubActionTargetState<Present, 'Identifier, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            ({ assignments = state.assignments } : SecurityhubActionTargetState<Present, 'Identifier, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_action_target#identifier-1">SecurityhubActionTarget#identifier</a>.
        /// </summary>
        [<CustomOperation "identifier">]
        member _.Identifier(state: SecurityhubActionTargetState<'Description, Missing, 'Name>, value: string) : SecurityhubActionTargetState<'Description, Present, 'Name> =
            state.assignments.Add(fun config -> config.Identifier <- value)
            ({ assignments = state.assignments } : SecurityhubActionTargetState<'Description, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_action_target#name-1">SecurityhubActionTarget#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SecurityhubActionTargetState<'Description, 'Identifier, Missing>, value: string) : SecurityhubActionTargetState<'Description, 'Identifier, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SecurityhubActionTargetState<'Description, 'Identifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_action_target#id-1">SecurityhubActionTarget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityhubActionTargetState<'Description, 'Identifier, 'Name>, value: string) : SecurityhubActionTargetState<'Description, 'Identifier, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityhubActionTargetState<'Description, 'Identifier, 'Name>

        member _.Run(state: SecurityhubActionTargetState<Present, Present, Present>) : aws.SecurityhubActionTarget.SecurityhubActionTarget =
            let config = aws.SecurityhubActionTarget.SecurityhubActionTargetConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubActionTarget.SecurityhubActionTarget(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityhubActionTarget: missing required arguments. Must call: description, identifier, name.", 9999, IsError = true)>]
        member _.Run(_: SecurityhubActionTargetState<_, _, _>) : aws.SecurityhubActionTarget.SecurityhubActionTarget =
            Unchecked.defaultof<aws.SecurityhubActionTarget.SecurityhubActionTarget>
