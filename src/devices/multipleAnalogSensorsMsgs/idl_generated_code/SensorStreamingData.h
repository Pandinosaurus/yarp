/*
 * SPDX-FileCopyrightText: 2006-2021 Istituto Italiano di Tecnologia (IIT)
 * SPDX-License-Identifier: BSD-3-Clause
 */

// Autogenerated by Thrift Compiler (0.14.1-yarped)
//
// This is an automatically generated file.
// It could get re-generated if the ALLOW_IDL_GENERATION flag is on.

#ifndef YARP_THRIFT_GENERATOR_STRUCT_SENSORSTREAMINGDATA_H
#define YARP_THRIFT_GENERATOR_STRUCT_SENSORSTREAMINGDATA_H

#include <yarp/os/Wire.h>
#include <yarp/os/idl/WireTypes.h>
#include <SensorMeasurements.h>

class SensorStreamingData :
        public yarp::os::idl::WirePortable
{
public:
    // Fields
    SensorMeasurements ThreeAxisGyroscopes;
    SensorMeasurements ThreeAxisLinearAccelerometers;
    SensorMeasurements ThreeAxisMagnetometers;
    SensorMeasurements OrientationSensors;
    SensorMeasurements TemperatureSensors;
    SensorMeasurements SixAxisForceTorqueSensors;
    SensorMeasurements ContactLoadCellArrays;
    SensorMeasurements EncoderArrays;
    SensorMeasurements SkinPatches;
    SensorMeasurements PositionSensors;

    // Default constructor
    SensorStreamingData();

    // Constructor with field values
    SensorStreamingData(const SensorMeasurements& ThreeAxisGyroscopes,
                        const SensorMeasurements& ThreeAxisLinearAccelerometers,
                        const SensorMeasurements& ThreeAxisMagnetometers,
                        const SensorMeasurements& OrientationSensors,
                        const SensorMeasurements& TemperatureSensors,
                        const SensorMeasurements& SixAxisForceTorqueSensors,
                        const SensorMeasurements& ContactLoadCellArrays,
                        const SensorMeasurements& EncoderArrays,
                        const SensorMeasurements& SkinPatches,
                        const SensorMeasurements& PositionSensors);

    // Read structure on a Wire
    bool read(yarp::os::idl::WireReader& reader) override;

    // Read structure on a Connection
    bool read(yarp::os::ConnectionReader& connection) override;

    // Write structure on a Wire
    bool write(const yarp::os::idl::WireWriter& writer) const override;

    // Write structure on a Connection
    bool write(yarp::os::ConnectionWriter& connection) const override;

    // Convert to a printable string
    std::string toString() const;

    // If you want to serialize this class without nesting, use this helper
    typedef yarp::os::idl::Unwrapped<SensorStreamingData> unwrapped;

    class Editor :
            public yarp::os::Wire,
            public yarp::os::PortWriter
    {
    public:
        // Editor: default constructor
        Editor();

        // Editor: constructor with base class
        Editor(SensorStreamingData& obj);

        // Editor: destructor
        ~Editor() override;

        // Editor: Deleted constructors and operator=
        Editor(const Editor& rhs) = delete;
        Editor(Editor&& rhs) = delete;
        Editor& operator=(const Editor& rhs) = delete;
        Editor& operator=(Editor&& rhs) = delete;

        // Editor: edit
        bool edit(SensorStreamingData& obj, bool dirty = true);

        // Editor: validity check
        bool isValid() const;

        // Editor: state
        SensorStreamingData& state();

        // Editor: start editing
        void start_editing();

#ifndef YARP_NO_DEPRECATED // Since YARP 3.2
        YARP_DEPRECATED_MSG("Use start_editing() instead")
        void begin()
        {
            start_editing();
        }
#endif // YARP_NO_DEPRECATED

        // Editor: stop editing
        void stop_editing();

#ifndef YARP_NO_DEPRECATED // Since YARP 3.2
        YARP_DEPRECATED_MSG("Use stop_editing() instead")
        void end()
        {
            stop_editing();
        }
#endif // YARP_NO_DEPRECATED

        // Editor: ThreeAxisGyroscopes field
        void set_ThreeAxisGyroscopes(const SensorMeasurements& ThreeAxisGyroscopes);
        const SensorMeasurements& get_ThreeAxisGyroscopes() const;
        virtual bool will_set_ThreeAxisGyroscopes();
        virtual bool did_set_ThreeAxisGyroscopes();

        // Editor: ThreeAxisLinearAccelerometers field
        void set_ThreeAxisLinearAccelerometers(const SensorMeasurements& ThreeAxisLinearAccelerometers);
        const SensorMeasurements& get_ThreeAxisLinearAccelerometers() const;
        virtual bool will_set_ThreeAxisLinearAccelerometers();
        virtual bool did_set_ThreeAxisLinearAccelerometers();

        // Editor: ThreeAxisMagnetometers field
        void set_ThreeAxisMagnetometers(const SensorMeasurements& ThreeAxisMagnetometers);
        const SensorMeasurements& get_ThreeAxisMagnetometers() const;
        virtual bool will_set_ThreeAxisMagnetometers();
        virtual bool did_set_ThreeAxisMagnetometers();

        // Editor: OrientationSensors field
        void set_OrientationSensors(const SensorMeasurements& OrientationSensors);
        const SensorMeasurements& get_OrientationSensors() const;
        virtual bool will_set_OrientationSensors();
        virtual bool did_set_OrientationSensors();

        // Editor: TemperatureSensors field
        void set_TemperatureSensors(const SensorMeasurements& TemperatureSensors);
        const SensorMeasurements& get_TemperatureSensors() const;
        virtual bool will_set_TemperatureSensors();
        virtual bool did_set_TemperatureSensors();

        // Editor: SixAxisForceTorqueSensors field
        void set_SixAxisForceTorqueSensors(const SensorMeasurements& SixAxisForceTorqueSensors);
        const SensorMeasurements& get_SixAxisForceTorqueSensors() const;
        virtual bool will_set_SixAxisForceTorqueSensors();
        virtual bool did_set_SixAxisForceTorqueSensors();

        // Editor: ContactLoadCellArrays field
        void set_ContactLoadCellArrays(const SensorMeasurements& ContactLoadCellArrays);
        const SensorMeasurements& get_ContactLoadCellArrays() const;
        virtual bool will_set_ContactLoadCellArrays();
        virtual bool did_set_ContactLoadCellArrays();

        // Editor: EncoderArrays field
        void set_EncoderArrays(const SensorMeasurements& EncoderArrays);
        const SensorMeasurements& get_EncoderArrays() const;
        virtual bool will_set_EncoderArrays();
        virtual bool did_set_EncoderArrays();

        // Editor: SkinPatches field
        void set_SkinPatches(const SensorMeasurements& SkinPatches);
        const SensorMeasurements& get_SkinPatches() const;
        virtual bool will_set_SkinPatches();
        virtual bool did_set_SkinPatches();

        // Editor: PositionSensors field
        void set_PositionSensors(const SensorMeasurements& PositionSensors);
        const SensorMeasurements& get_PositionSensors() const;
        virtual bool will_set_PositionSensors();
        virtual bool did_set_PositionSensors();

        // Editor: clean
        void clean();

        // Editor: read
        bool read(yarp::os::ConnectionReader& connection) override;

        // Editor: write
        bool write(yarp::os::ConnectionWriter& connection) const override;

    private:
        // Editor: state
        SensorStreamingData* obj;
        bool obj_owned;
        int group;

        // Editor: dirty variables
        bool is_dirty;
        bool is_dirty_ThreeAxisGyroscopes;
        bool is_dirty_ThreeAxisLinearAccelerometers;
        bool is_dirty_ThreeAxisMagnetometers;
        bool is_dirty_OrientationSensors;
        bool is_dirty_TemperatureSensors;
        bool is_dirty_SixAxisForceTorqueSensors;
        bool is_dirty_ContactLoadCellArrays;
        bool is_dirty_EncoderArrays;
        bool is_dirty_SkinPatches;
        bool is_dirty_PositionSensors;
        int dirty_count;

        // Editor: send if possible
        void communicate();

        // Editor: mark dirty overall
        void mark_dirty();

        // Editor: mark dirty single fields
        void mark_dirty_ThreeAxisGyroscopes();
        void mark_dirty_ThreeAxisLinearAccelerometers();
        void mark_dirty_ThreeAxisMagnetometers();
        void mark_dirty_OrientationSensors();
        void mark_dirty_TemperatureSensors();
        void mark_dirty_SixAxisForceTorqueSensors();
        void mark_dirty_ContactLoadCellArrays();
        void mark_dirty_EncoderArrays();
        void mark_dirty_SkinPatches();
        void mark_dirty_PositionSensors();

        // Editor: dirty_flags
        void dirty_flags(bool flag);
    };

private:
    // read/write ThreeAxisGyroscopes field
    bool read_ThreeAxisGyroscopes(yarp::os::idl::WireReader& reader);
    bool write_ThreeAxisGyroscopes(const yarp::os::idl::WireWriter& writer) const;
    bool nested_read_ThreeAxisGyroscopes(yarp::os::idl::WireReader& reader);
    bool nested_write_ThreeAxisGyroscopes(const yarp::os::idl::WireWriter& writer) const;

    // read/write ThreeAxisLinearAccelerometers field
    bool read_ThreeAxisLinearAccelerometers(yarp::os::idl::WireReader& reader);
    bool write_ThreeAxisLinearAccelerometers(const yarp::os::idl::WireWriter& writer) const;
    bool nested_read_ThreeAxisLinearAccelerometers(yarp::os::idl::WireReader& reader);
    bool nested_write_ThreeAxisLinearAccelerometers(const yarp::os::idl::WireWriter& writer) const;

    // read/write ThreeAxisMagnetometers field
    bool read_ThreeAxisMagnetometers(yarp::os::idl::WireReader& reader);
    bool write_ThreeAxisMagnetometers(const yarp::os::idl::WireWriter& writer) const;
    bool nested_read_ThreeAxisMagnetometers(yarp::os::idl::WireReader& reader);
    bool nested_write_ThreeAxisMagnetometers(const yarp::os::idl::WireWriter& writer) const;

    // read/write OrientationSensors field
    bool read_OrientationSensors(yarp::os::idl::WireReader& reader);
    bool write_OrientationSensors(const yarp::os::idl::WireWriter& writer) const;
    bool nested_read_OrientationSensors(yarp::os::idl::WireReader& reader);
    bool nested_write_OrientationSensors(const yarp::os::idl::WireWriter& writer) const;

    // read/write TemperatureSensors field
    bool read_TemperatureSensors(yarp::os::idl::WireReader& reader);
    bool write_TemperatureSensors(const yarp::os::idl::WireWriter& writer) const;
    bool nested_read_TemperatureSensors(yarp::os::idl::WireReader& reader);
    bool nested_write_TemperatureSensors(const yarp::os::idl::WireWriter& writer) const;

    // read/write SixAxisForceTorqueSensors field
    bool read_SixAxisForceTorqueSensors(yarp::os::idl::WireReader& reader);
    bool write_SixAxisForceTorqueSensors(const yarp::os::idl::WireWriter& writer) const;
    bool nested_read_SixAxisForceTorqueSensors(yarp::os::idl::WireReader& reader);
    bool nested_write_SixAxisForceTorqueSensors(const yarp::os::idl::WireWriter& writer) const;

    // read/write ContactLoadCellArrays field
    bool read_ContactLoadCellArrays(yarp::os::idl::WireReader& reader);
    bool write_ContactLoadCellArrays(const yarp::os::idl::WireWriter& writer) const;
    bool nested_read_ContactLoadCellArrays(yarp::os::idl::WireReader& reader);
    bool nested_write_ContactLoadCellArrays(const yarp::os::idl::WireWriter& writer) const;

    // read/write EncoderArrays field
    bool read_EncoderArrays(yarp::os::idl::WireReader& reader);
    bool write_EncoderArrays(const yarp::os::idl::WireWriter& writer) const;
    bool nested_read_EncoderArrays(yarp::os::idl::WireReader& reader);
    bool nested_write_EncoderArrays(const yarp::os::idl::WireWriter& writer) const;

    // read/write SkinPatches field
    bool read_SkinPatches(yarp::os::idl::WireReader& reader);
    bool write_SkinPatches(const yarp::os::idl::WireWriter& writer) const;
    bool nested_read_SkinPatches(yarp::os::idl::WireReader& reader);
    bool nested_write_SkinPatches(const yarp::os::idl::WireWriter& writer) const;

    // read/write PositionSensors field
    bool read_PositionSensors(yarp::os::idl::WireReader& reader);
    bool write_PositionSensors(const yarp::os::idl::WireWriter& writer) const;
    bool nested_read_PositionSensors(yarp::os::idl::WireReader& reader);
    bool nested_write_PositionSensors(const yarp::os::idl::WireWriter& writer) const;
};

#endif // YARP_THRIFT_GENERATOR_STRUCT_SENSORSTREAMINGDATA_H
