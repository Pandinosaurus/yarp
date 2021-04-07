/*
 * Copyright (C) 2006-2021 Istituto Italiano di Tecnologia (IIT)
 * All rights reserved.
 *
 * This software may be modified and distributed under the terms of the
 * BSD-3-Clause license. See the accompanying LICENSE file for details.
 */

// Autogenerated by Thrift Compiler (0.14.1-yarped)
//
// This is an automatically generated file.
// It could get re-generated if the ALLOW_IDL_GENERATION flag is on.

#ifndef YARP_THRIFT_GENERATOR_STRUCT_AUDIORECORDERSTATUS_H
#define YARP_THRIFT_GENERATOR_STRUCT_AUDIORECORDERSTATUS_H

#include <yarp/dev/api.h>

#include <yarp/os/Wire.h>
#include <yarp/os/idl/WireTypes.h>

#include <yarp/dev/audioRecorderStatus_common.h>

namespace yarp {
namespace dev {

class YARP_dev_API audioRecorderStatus :
        public yarp::os::idl::WirePortable
{
public:
    // Fields
    /**
     * true if the playback is currently enabled
     */
    bool enabled;
    /**
     * the size of the audio buffer [samples]
     */
    size_t current_buffer_size;
    /**
     * the max_size of the audio buffer [samples]
     */
    size_t max_buffer_size;

    // Default constructor
    audioRecorderStatus();

    // Constructor with field values
    audioRecorderStatus(const bool enabled,
                        const size_t current_buffer_size,
                        const size_t max_buffer_size);

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
    typedef yarp::os::idl::Unwrapped<audioRecorderStatus> unwrapped;

    class Editor :
            public yarp::os::Wire,
            public yarp::os::PortWriter
    {
    public:
        // Editor: default constructor
        Editor();

        // Editor: constructor with base class
        Editor(audioRecorderStatus& obj);

        // Editor: destructor
        ~Editor() override;

        // Editor: Deleted constructors and operator=
        Editor(const Editor& rhs) = delete;
        Editor(Editor&& rhs) = delete;
        Editor& operator=(const Editor& rhs) = delete;
        Editor& operator=(Editor&& rhs) = delete;

        // Editor: edit
        bool edit(audioRecorderStatus& obj, bool dirty = true);

        // Editor: validity check
        bool isValid() const;

        // Editor: state
        audioRecorderStatus& state();

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

        // Editor: enabled field
        void set_enabled(const bool enabled);
        bool get_enabled() const;
        virtual bool will_set_enabled();
        virtual bool did_set_enabled();

        // Editor: current_buffer_size field
        void set_current_buffer_size(const size_t current_buffer_size);
        size_t get_current_buffer_size() const;
        virtual bool will_set_current_buffer_size();
        virtual bool did_set_current_buffer_size();

        // Editor: max_buffer_size field
        void set_max_buffer_size(const size_t max_buffer_size);
        size_t get_max_buffer_size() const;
        virtual bool will_set_max_buffer_size();
        virtual bool did_set_max_buffer_size();

        // Editor: clean
        void clean();

        // Editor: read
        bool read(yarp::os::ConnectionReader& connection) override;

        // Editor: write
        bool write(yarp::os::ConnectionWriter& connection) const override;

    private:
        // Editor: state
        audioRecorderStatus* obj;
        bool obj_owned;
        int group;

        // Editor: dirty variables
        bool is_dirty;
        bool is_dirty_enabled;
        bool is_dirty_current_buffer_size;
        bool is_dirty_max_buffer_size;
        int dirty_count;

        // Editor: send if possible
        void communicate();

        // Editor: mark dirty overall
        void mark_dirty();

        // Editor: mark dirty single fields
        void mark_dirty_enabled();
        void mark_dirty_current_buffer_size();
        void mark_dirty_max_buffer_size();

        // Editor: dirty_flags
        void dirty_flags(bool flag);
    };

private:
    // read/write enabled field
    bool read_enabled(yarp::os::idl::WireReader& reader);
    bool write_enabled(const yarp::os::idl::WireWriter& writer) const;
    bool nested_read_enabled(yarp::os::idl::WireReader& reader);
    bool nested_write_enabled(const yarp::os::idl::WireWriter& writer) const;

    // read/write current_buffer_size field
    bool read_current_buffer_size(yarp::os::idl::WireReader& reader);
    bool write_current_buffer_size(const yarp::os::idl::WireWriter& writer) const;
    bool nested_read_current_buffer_size(yarp::os::idl::WireReader& reader);
    bool nested_write_current_buffer_size(const yarp::os::idl::WireWriter& writer) const;

    // read/write max_buffer_size field
    bool read_max_buffer_size(yarp::os::idl::WireReader& reader);
    bool write_max_buffer_size(const yarp::os::idl::WireWriter& writer) const;
    bool nested_read_max_buffer_size(yarp::os::idl::WireReader& reader);
    bool nested_write_max_buffer_size(const yarp::os::idl::WireWriter& writer) const;
};

} // namespace yarp
} // namespace dev

#endif // YARP_THRIFT_GENERATOR_STRUCT_AUDIORECORDERSTATUS_H
