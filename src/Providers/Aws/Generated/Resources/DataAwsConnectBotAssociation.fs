namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectBotAssociationState<'InstanceId, 'LexBot> = { assignments: ResizeArray<aws.DataAwsConnectBotAssociation.DataAwsConnectBotAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_bot_association">aws_connect_bot_association</a>.
    /// </summary>
    type DataAwsConnectBotAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectBotAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectBotAssociationState<Missing, Missing>)

        member _.Zero(()) : DataAwsConnectBotAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectBotAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_bot_association#instance_id-1">DataAwsConnectBotAssociation#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectBotAssociationState<Missing, 'LexBot>, value: string) : DataAwsConnectBotAssociationState<Present, 'LexBot> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : DataAwsConnectBotAssociationState<Present, 'LexBot>)

        /// <summary>
        /// lex_bot block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_bot_association#lex_bot-1">DataAwsConnectBotAssociation#lex_bot</a>
        /// </summary>
        [<CustomOperation "lex_bot">]
        member _.LexBot(state: DataAwsConnectBotAssociationState<'InstanceId, Missing>, value: aws.DataAwsConnectBotAssociation.DataAwsConnectBotAssociationLexBot) : DataAwsConnectBotAssociationState<'InstanceId, Present> =
            state.assignments.Add(fun config -> config.LexBot <- value)
            ({ assignments = state.assignments } : DataAwsConnectBotAssociationState<'InstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_bot_association#id-1">DataAwsConnectBotAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectBotAssociationState<'InstanceId, 'LexBot>, value: string) : DataAwsConnectBotAssociationState<'InstanceId, 'LexBot> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectBotAssociationState<'InstanceId, 'LexBot>

        member _.Run(state: DataAwsConnectBotAssociationState<Present, Present>) : aws.DataAwsConnectBotAssociation.DataAwsConnectBotAssociation =
            let config = aws.DataAwsConnectBotAssociation.DataAwsConnectBotAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectBotAssociation.DataAwsConnectBotAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsConnectBotAssociation: missing required arguments. Must call: instance_id, lex_bot.", 9999, IsError = true)>]
        member _.Run(_: DataAwsConnectBotAssociationState<_, _>) : aws.DataAwsConnectBotAssociation.DataAwsConnectBotAssociation =
            Unchecked.defaultof<aws.DataAwsConnectBotAssociation.DataAwsConnectBotAssociation>
