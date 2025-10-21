namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevicefarmUploadState<'Name, 'ProjectArn, 'Type> = { assignments: ResizeArray<aws.DevicefarmUpload.DevicefarmUploadConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_upload">aws_devicefarm_upload</a>.
    /// </summary>
    type DevicefarmUploadBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevicefarmUploadState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevicefarmUploadState<Missing, Missing, Missing>)

        member _.Zero(()) : DevicefarmUploadState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevicefarmUploadState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_upload#name-1">DevicefarmUpload#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevicefarmUploadState<Missing, 'ProjectArn, 'Type>, value: string) : DevicefarmUploadState<Present, 'ProjectArn, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevicefarmUploadState<Present, 'ProjectArn, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_upload#project_arn-1">DevicefarmUpload#project_arn</a>.
        /// </summary>
        [<CustomOperation "project_arn">]
        member _.ProjectArn(state: DevicefarmUploadState<'Name, Missing, 'Type>, value: string) : DevicefarmUploadState<'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.ProjectArn <- value)
            ({ assignments = state.assignments } : DevicefarmUploadState<'Name, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_upload#type-1">DevicefarmUpload#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DevicefarmUploadState<'Name, 'ProjectArn, Missing>, value: string) : DevicefarmUploadState<'Name, 'ProjectArn, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : DevicefarmUploadState<'Name, 'ProjectArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_upload#content_type-1">DevicefarmUpload#content_type</a>.
        /// </summary>
        [<CustomOperation "content_type">]
        member _.ContentType(state: DevicefarmUploadState<'Name, 'ProjectArn, 'Type>, value: string) : DevicefarmUploadState<'Name, 'ProjectArn, 'Type> =
            state.assignments.Add(fun config -> config.ContentType <- value)
            state : DevicefarmUploadState<'Name, 'ProjectArn, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devicefarm_upload#id-1">DevicefarmUpload#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevicefarmUploadState<'Name, 'ProjectArn, 'Type>, value: string) : DevicefarmUploadState<'Name, 'ProjectArn, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevicefarmUploadState<'Name, 'ProjectArn, 'Type>

        member _.Run(state: DevicefarmUploadState<Present, Present, Present>) : aws.DevicefarmUpload.DevicefarmUpload =
            let config = aws.DevicefarmUpload.DevicefarmUploadConfig()
            for setter in state.assignments do
                setter config
            aws.DevicefarmUpload.DevicefarmUpload(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.devicefarmUpload: missing required arguments. Must call: name, project_arn, type.", 9999, IsError = true)>]
        member _.Run(_: DevicefarmUploadState<_, _, _>) : aws.DevicefarmUpload.DevicefarmUpload =
            Unchecked.defaultof<aws.DevicefarmUpload.DevicefarmUpload>
