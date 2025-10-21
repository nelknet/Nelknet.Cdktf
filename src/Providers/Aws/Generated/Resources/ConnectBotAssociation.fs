namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectBotAssociationState<'InstanceId, 'LexBot> = { assignments: ResizeArray<aws.ConnectBotAssociation.ConnectBotAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_bot_association">aws_connect_bot_association</a>.
    /// </summary>
    type ConnectBotAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectBotAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectBotAssociationState<Missing, Missing>)

        member _.Zero(()) : ConnectBotAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectBotAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_bot_association#instance_id-1">ConnectBotAssociation#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ConnectBotAssociationState<Missing, 'LexBot>, value: string) : ConnectBotAssociationState<Present, 'LexBot> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ConnectBotAssociationState<Present, 'LexBot>)

        /// <summary>
        /// lex_bot block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_bot_association#lex_bot-1">ConnectBotAssociation#lex_bot</a>
        /// </summary>
        [<CustomOperation "lex_bot">]
        member _.LexBot(state: ConnectBotAssociationState<'InstanceId, Missing>, value: aws.ConnectBotAssociation.ConnectBotAssociationLexBot) : ConnectBotAssociationState<'InstanceId, Present> =
            state.assignments.Add(fun config -> config.LexBot <- value)
            ({ assignments = state.assignments } : ConnectBotAssociationState<'InstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_bot_association#id-1">ConnectBotAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectBotAssociationState<'InstanceId, 'LexBot>, value: string) : ConnectBotAssociationState<'InstanceId, 'LexBot> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectBotAssociationState<'InstanceId, 'LexBot>

        member _.Run(state: ConnectBotAssociationState<Present, Present>) : aws.ConnectBotAssociation.ConnectBotAssociation =
            let config = aws.ConnectBotAssociation.ConnectBotAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectBotAssociation.ConnectBotAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectBotAssociation: missing required arguments. Must call: instance_id, lex_bot.", 9999, IsError = true)>]
        member _.Run(_: ConnectBotAssociationState<_, _>) : aws.ConnectBotAssociation.ConnectBotAssociation =
            Unchecked.defaultof<aws.ConnectBotAssociation.ConnectBotAssociation>
