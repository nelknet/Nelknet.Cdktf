using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveChannel
{
    [JsiiInterface(nativeType: typeof(IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings")]
    public interface IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#outline_color MedialiveChannel#outline_color}.</summary>
        [JsiiProperty(name: "outlineColor", typeJson: "{\"primitive\":\"string\"}")]
        string OutlineColor
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#teletext_grid_control MedialiveChannel#teletext_grid_control}.</summary>
        [JsiiProperty(name: "teletextGridControl", typeJson: "{\"primitive\":\"string\"}")]
        string TeletextGridControl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#alignment MedialiveChannel#alignment}.</summary>
        [JsiiProperty(name: "alignment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alignment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#background_color MedialiveChannel#background_color}.</summary>
        [JsiiProperty(name: "backgroundColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackgroundColor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#background_opacity MedialiveChannel#background_opacity}.</summary>
        [JsiiProperty(name: "backgroundOpacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackgroundOpacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>font block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#font MedialiveChannel#font}
        /// </remarks>
        [JsiiProperty(name: "font", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont? Font
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#font_color MedialiveChannel#font_color}.</summary>
        [JsiiProperty(name: "fontColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FontColor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#font_opacity MedialiveChannel#font_opacity}.</summary>
        [JsiiProperty(name: "fontOpacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FontOpacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#font_resolution MedialiveChannel#font_resolution}.</summary>
        [JsiiProperty(name: "fontResolution", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FontResolution
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#font_size MedialiveChannel#font_size}.</summary>
        [JsiiProperty(name: "fontSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FontSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#outline_size MedialiveChannel#outline_size}.</summary>
        [JsiiProperty(name: "outlineSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OutlineSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#shadow_color MedialiveChannel#shadow_color}.</summary>
        [JsiiProperty(name: "shadowColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShadowColor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#shadow_opacity MedialiveChannel#shadow_opacity}.</summary>
        [JsiiProperty(name: "shadowOpacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ShadowOpacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#shadow_x_offset MedialiveChannel#shadow_x_offset}.</summary>
        [JsiiProperty(name: "shadowXOffset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ShadowXOffset
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#shadow_y_offset MedialiveChannel#shadow_y_offset}.</summary>
        [JsiiProperty(name: "shadowYOffset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ShadowYOffset
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#x_position MedialiveChannel#x_position}.</summary>
        [JsiiProperty(name: "xPosition", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? XPosition
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#y_position MedialiveChannel#y_position}.</summary>
        [JsiiProperty(name: "yPosition", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? YPosition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings), fullyQualifiedName: "aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings")]
        internal sealed class _Proxy : DeputyBase, aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#outline_color MedialiveChannel#outline_color}.</summary>
            [JsiiProperty(name: "outlineColor", typeJson: "{\"primitive\":\"string\"}")]
            public string OutlineColor
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#teletext_grid_control MedialiveChannel#teletext_grid_control}.</summary>
            [JsiiProperty(name: "teletextGridControl", typeJson: "{\"primitive\":\"string\"}")]
            public string TeletextGridControl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#alignment MedialiveChannel#alignment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alignment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alignment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#background_color MedialiveChannel#background_color}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backgroundColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackgroundColor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#background_opacity MedialiveChannel#background_opacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backgroundOpacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackgroundOpacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>font block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#font MedialiveChannel#font}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "font", typeJson: "{\"fqn\":\"aws.medialiveChannel.MedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont\"}", isOptional: true)]
            public aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont? Font
            {
                get => GetInstanceProperty<aws.MedialiveChannel.IMedialiveChannelEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#font_color MedialiveChannel#font_color}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fontColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FontColor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#font_opacity MedialiveChannel#font_opacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fontOpacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FontOpacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#font_resolution MedialiveChannel#font_resolution}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fontResolution", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FontResolution
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#font_size MedialiveChannel#font_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fontSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FontSize
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#outline_size MedialiveChannel#outline_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outlineSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OutlineSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#shadow_color MedialiveChannel#shadow_color}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shadowColor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShadowColor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#shadow_opacity MedialiveChannel#shadow_opacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shadowOpacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ShadowOpacity
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#shadow_x_offset MedialiveChannel#shadow_x_offset}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shadowXOffset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ShadowXOffset
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#shadow_y_offset MedialiveChannel#shadow_y_offset}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shadowYOffset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ShadowYOffset
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#x_position MedialiveChannel#x_position}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "xPosition", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? XPosition
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_channel#y_position MedialiveChannel#y_position}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "yPosition", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? YPosition
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
