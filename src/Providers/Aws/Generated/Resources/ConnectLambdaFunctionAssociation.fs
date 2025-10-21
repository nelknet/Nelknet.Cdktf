namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConnectLambdaFunctionAssociationState<'FunctionArn, 'InstanceId> = { assignments: ResizeArray<aws.ConnectLambdaFunctionAssociation.ConnectLambdaFunctionAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_lambda_function_association">aws_connect_lambda_function_association</a>.
    /// </summary>
    type ConnectLambdaFunctionAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConnectLambdaFunctionAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectLambdaFunctionAssociationState<Missing, Missing>)

        member _.Zero(()) : ConnectLambdaFunctionAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConnectLambdaFunctionAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_lambda_function_association#function_arn-1">ConnectLambdaFunctionAssociation#function_arn</a>.
        /// </summary>
        [<CustomOperation "function_arn">]
        member _.FunctionArn(state: ConnectLambdaFunctionAssociationState<Missing, 'InstanceId>, value: string) : ConnectLambdaFunctionAssociationState<Present, 'InstanceId> =
            state.assignments.Add(fun config -> config.FunctionArn <- value)
            ({ assignments = state.assignments } : ConnectLambdaFunctionAssociationState<Present, 'InstanceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_lambda_function_association#instance_id-1">ConnectLambdaFunctionAssociation#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: ConnectLambdaFunctionAssociationState<'FunctionArn, Missing>, value: string) : ConnectLambdaFunctionAssociationState<'FunctionArn, Present> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : ConnectLambdaFunctionAssociationState<'FunctionArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_lambda_function_association#id-1">ConnectLambdaFunctionAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConnectLambdaFunctionAssociationState<'FunctionArn, 'InstanceId>, value: string) : ConnectLambdaFunctionAssociationState<'FunctionArn, 'InstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConnectLambdaFunctionAssociationState<'FunctionArn, 'InstanceId>

        member _.Run(state: ConnectLambdaFunctionAssociationState<Present, Present>) : aws.ConnectLambdaFunctionAssociation.ConnectLambdaFunctionAssociation =
            let config = aws.ConnectLambdaFunctionAssociation.ConnectLambdaFunctionAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.ConnectLambdaFunctionAssociation.ConnectLambdaFunctionAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.connectLambdaFunctionAssociation: missing required arguments. Must call: function_arn, instance_id.", 9999, IsError = true)>]
        member _.Run(_: ConnectLambdaFunctionAssociationState<_, _>) : aws.ConnectLambdaFunctionAssociation.ConnectLambdaFunctionAssociation =
            Unchecked.defaultof<aws.ConnectLambdaFunctionAssociation.ConnectLambdaFunctionAssociation>
