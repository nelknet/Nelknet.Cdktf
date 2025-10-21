namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsConnectLambdaFunctionAssociationState<'FunctionArn, 'InstanceId> = { assignments: ResizeArray<aws.DataAwsConnectLambdaFunctionAssociation.DataAwsConnectLambdaFunctionAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_lambda_function_association">aws_connect_lambda_function_association</a>.
    /// </summary>
    type DataAwsConnectLambdaFunctionAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsConnectLambdaFunctionAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectLambdaFunctionAssociationState<Missing, Missing>)

        member _.Zero(()) : DataAwsConnectLambdaFunctionAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsConnectLambdaFunctionAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_lambda_function_association#function_arn-1">DataAwsConnectLambdaFunctionAssociation#function_arn</a>.
        /// </summary>
        [<CustomOperation "function_arn">]
        member _.FunctionArn(state: DataAwsConnectLambdaFunctionAssociationState<Missing, 'InstanceId>, value: string) : DataAwsConnectLambdaFunctionAssociationState<Present, 'InstanceId> =
            state.assignments.Add(fun config -> config.FunctionArn <- value)
            ({ assignments = state.assignments } : DataAwsConnectLambdaFunctionAssociationState<Present, 'InstanceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_lambda_function_association#instance_id-1">DataAwsConnectLambdaFunctionAssociation#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: DataAwsConnectLambdaFunctionAssociationState<'FunctionArn, Missing>, value: string) : DataAwsConnectLambdaFunctionAssociationState<'FunctionArn, Present> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : DataAwsConnectLambdaFunctionAssociationState<'FunctionArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/connect_lambda_function_association#id-1">DataAwsConnectLambdaFunctionAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsConnectLambdaFunctionAssociationState<'FunctionArn, 'InstanceId>, value: string) : DataAwsConnectLambdaFunctionAssociationState<'FunctionArn, 'InstanceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsConnectLambdaFunctionAssociationState<'FunctionArn, 'InstanceId>

        member _.Run(state: DataAwsConnectLambdaFunctionAssociationState<Present, Present>) : aws.DataAwsConnectLambdaFunctionAssociation.DataAwsConnectLambdaFunctionAssociation =
            let config = aws.DataAwsConnectLambdaFunctionAssociation.DataAwsConnectLambdaFunctionAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsConnectLambdaFunctionAssociation.DataAwsConnectLambdaFunctionAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsConnectLambdaFunctionAssociation: missing required arguments. Must call: function_arn, instance_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsConnectLambdaFunctionAssociationState<_, _>) : aws.DataAwsConnectLambdaFunctionAssociation.DataAwsConnectLambdaFunctionAssociation =
            Unchecked.defaultof<aws.DataAwsConnectLambdaFunctionAssociation.DataAwsConnectLambdaFunctionAssociation>
