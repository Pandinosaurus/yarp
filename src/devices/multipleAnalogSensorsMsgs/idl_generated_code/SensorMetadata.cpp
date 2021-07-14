/*
 * SPDX-FileCopyrightText: 2006-2021 Istituto Italiano di Tecnologia (IIT)
 * SPDX-License-Identifier: BSD-3-Clause
 */

// Autogenerated by Thrift Compiler (0.14.1-yarped)
//
// This is an automatically generated file.
// It could get re-generated if the ALLOW_IDL_GENERATION flag is on.

#include <SensorMetadata.h>

// Default constructor
SensorMetadata::SensorMetadata() :
        WirePortable(),
        name(""),
        frameName(""),
        additionalMetadata("")
{
}

// Constructor with field values
SensorMetadata::SensorMetadata(const std::string& name,
                               const std::string& frameName,
                               const std::string& additionalMetadata) :
        WirePortable(),
        name(name),
        frameName(frameName),
        additionalMetadata(additionalMetadata)
{
}

// Read structure on a Wire
bool SensorMetadata::read(yarp::os::idl::WireReader& reader)
{
    if (!read_name(reader)) {
        return false;
    }
    if (!read_frameName(reader)) {
        return false;
    }
    if (!read_additionalMetadata(reader)) {
        return false;
    }
    return !reader.isError();
}

// Read structure on a Connection
bool SensorMetadata::read(yarp::os::ConnectionReader& connection)
{
    yarp::os::idl::WireReader reader(connection);
    if (!reader.readListHeader(3)) {
        return false;
    }
    return read(reader);
}

// Write structure on a Wire
bool SensorMetadata::write(const yarp::os::idl::WireWriter& writer) const
{
    if (!write_name(writer)) {
        return false;
    }
    if (!write_frameName(writer)) {
        return false;
    }
    if (!write_additionalMetadata(writer)) {
        return false;
    }
    return !writer.isError();
}

// Write structure on a Connection
bool SensorMetadata::write(yarp::os::ConnectionWriter& connection) const
{
    yarp::os::idl::WireWriter writer(connection);
    if (!writer.writeListHeader(3)) {
        return false;
    }
    return write(writer);
}

// Convert to a printable string
std::string SensorMetadata::toString() const
{
    yarp::os::Bottle b;
    b.read(*this);
    return b.toString();
}

// Editor: default constructor
SensorMetadata::Editor::Editor()
{
    group = 0;
    obj_owned = true;
    obj = new SensorMetadata;
    dirty_flags(false);
    yarp().setOwner(*this);
}

// Editor: constructor with base class
SensorMetadata::Editor::Editor(SensorMetadata& obj)
{
    group = 0;
    obj_owned = false;
    edit(obj, false);
    yarp().setOwner(*this);
}

// Editor: destructor
SensorMetadata::Editor::~Editor()
{
    if (obj_owned) {
        delete obj;
    }
}

// Editor: edit
bool SensorMetadata::Editor::edit(SensorMetadata& obj, bool dirty)
{
    if (obj_owned) {
        delete this->obj;
    }
    this->obj = &obj;
    obj_owned = false;
    dirty_flags(dirty);
    return true;
}

// Editor: validity check
bool SensorMetadata::Editor::isValid() const
{
    return obj != nullptr;
}

// Editor: state
SensorMetadata& SensorMetadata::Editor::state()
{
    return *obj;
}

// Editor: grouping begin
void SensorMetadata::Editor::start_editing()
{
    group++;
}

// Editor: grouping end
void SensorMetadata::Editor::stop_editing()
{
    group--;
    if (group == 0 && is_dirty) {
        communicate();
    }
}
// Editor: name setter
void SensorMetadata::Editor::set_name(const std::string& name)
{
    will_set_name();
    obj->name = name;
    mark_dirty_name();
    communicate();
    did_set_name();
}

// Editor: name getter
const std::string& SensorMetadata::Editor::get_name() const
{
    return obj->name;
}

// Editor: name will_set
bool SensorMetadata::Editor::will_set_name()
{
    return true;
}

// Editor: name did_set
bool SensorMetadata::Editor::did_set_name()
{
    return true;
}

// Editor: frameName setter
void SensorMetadata::Editor::set_frameName(const std::string& frameName)
{
    will_set_frameName();
    obj->frameName = frameName;
    mark_dirty_frameName();
    communicate();
    did_set_frameName();
}

// Editor: frameName getter
const std::string& SensorMetadata::Editor::get_frameName() const
{
    return obj->frameName;
}

// Editor: frameName will_set
bool SensorMetadata::Editor::will_set_frameName()
{
    return true;
}

// Editor: frameName did_set
bool SensorMetadata::Editor::did_set_frameName()
{
    return true;
}

// Editor: additionalMetadata setter
void SensorMetadata::Editor::set_additionalMetadata(const std::string& additionalMetadata)
{
    will_set_additionalMetadata();
    obj->additionalMetadata = additionalMetadata;
    mark_dirty_additionalMetadata();
    communicate();
    did_set_additionalMetadata();
}

// Editor: additionalMetadata getter
const std::string& SensorMetadata::Editor::get_additionalMetadata() const
{
    return obj->additionalMetadata;
}

// Editor: additionalMetadata will_set
bool SensorMetadata::Editor::will_set_additionalMetadata()
{
    return true;
}

// Editor: additionalMetadata did_set
bool SensorMetadata::Editor::did_set_additionalMetadata()
{
    return true;
}

// Editor: clean
void SensorMetadata::Editor::clean()
{
    dirty_flags(false);
}

// Editor: read
bool SensorMetadata::Editor::read(yarp::os::ConnectionReader& connection)
{
    if (!isValid()) {
        return false;
    }
    yarp::os::idl::WireReader reader(connection);
    reader.expectAccept();
    if (!reader.readListHeader()) {
        return false;
    }
    int len = reader.getLength();
    if (len == 0) {
        yarp::os::idl::WireWriter writer(reader);
        if (writer.isNull()) {
            return true;
        }
        if (!writer.writeListHeader(1)) {
            return false;
        }
        writer.writeString("send: 'help' or 'patch (param1 val1) (param2 val2)'");
        return true;
    }
    std::string tag;
    if (!reader.readString(tag)) {
        return false;
    }
    if (tag == "help") {
        yarp::os::idl::WireWriter writer(reader);
        if (writer.isNull()) {
            return true;
        }
        if (!writer.writeListHeader(2)) {
            return false;
        }
        if (!writer.writeTag("many", 1, 0)) {
            return false;
        }
        if (reader.getLength() > 0) {
            std::string field;
            if (!reader.readString(field)) {
                return false;
            }
            if (field == "name") {
                if (!writer.writeListHeader(1)) {
                    return false;
                }
                if (!writer.writeString("std::string name")) {
                    return false;
                }
            }
            if (field == "frameName") {
                if (!writer.writeListHeader(1)) {
                    return false;
                }
                if (!writer.writeString("std::string frameName")) {
                    return false;
                }
            }
            if (field == "additionalMetadata") {
                if (!writer.writeListHeader(1)) {
                    return false;
                }
                if (!writer.writeString("std::string additionalMetadata")) {
                    return false;
                }
            }
        }
        if (!writer.writeListHeader(4)) {
            return false;
        }
        writer.writeString("*** Available fields:");
        writer.writeString("name");
        writer.writeString("frameName");
        writer.writeString("additionalMetadata");
        return true;
    }
    bool nested = true;
    bool have_act = false;
    if (tag != "patch") {
        if (((len - 1) % 2) != 0) {
            return false;
        }
        len = 1 + ((len - 1) / 2);
        nested = false;
        have_act = true;
    }
    for (int i = 1; i < len; ++i) {
        if (nested && !reader.readListHeader(3)) {
            return false;
        }
        std::string act;
        std::string key;
        if (have_act) {
            act = tag;
        } else if (!reader.readString(act)) {
            return false;
        }
        if (!reader.readString(key)) {
            return false;
        }
        if (key == "name") {
            will_set_name();
            if (!obj->nested_read_name(reader)) {
                return false;
            }
            did_set_name();
        } else if (key == "frameName") {
            will_set_frameName();
            if (!obj->nested_read_frameName(reader)) {
                return false;
            }
            did_set_frameName();
        } else if (key == "additionalMetadata") {
            will_set_additionalMetadata();
            if (!obj->nested_read_additionalMetadata(reader)) {
                return false;
            }
            did_set_additionalMetadata();
        } else {
            // would be useful to have a fallback here
        }
    }
    reader.accept();
    yarp::os::idl::WireWriter writer(reader);
    if (writer.isNull()) {
        return true;
    }
    writer.writeListHeader(1);
    writer.writeVocab32('o', 'k');
    return true;
}

// Editor: write
bool SensorMetadata::Editor::write(yarp::os::ConnectionWriter& connection) const
{
    if (!isValid()) {
        return false;
    }
    yarp::os::idl::WireWriter writer(connection);
    if (!writer.writeListHeader(dirty_count + 1)) {
        return false;
    }
    if (!writer.writeString("patch")) {
        return false;
    }
    if (is_dirty_name) {
        if (!writer.writeListHeader(3)) {
            return false;
        }
        if (!writer.writeString("set")) {
            return false;
        }
        if (!writer.writeString("name")) {
            return false;
        }
        if (!obj->nested_write_name(writer)) {
            return false;
        }
    }
    if (is_dirty_frameName) {
        if (!writer.writeListHeader(3)) {
            return false;
        }
        if (!writer.writeString("set")) {
            return false;
        }
        if (!writer.writeString("frameName")) {
            return false;
        }
        if (!obj->nested_write_frameName(writer)) {
            return false;
        }
    }
    if (is_dirty_additionalMetadata) {
        if (!writer.writeListHeader(3)) {
            return false;
        }
        if (!writer.writeString("set")) {
            return false;
        }
        if (!writer.writeString("additionalMetadata")) {
            return false;
        }
        if (!obj->nested_write_additionalMetadata(writer)) {
            return false;
        }
    }
    return !writer.isError();
}

// Editor: send if possible
void SensorMetadata::Editor::communicate()
{
    if (group != 0) {
        return;
    }
    if (yarp().canWrite()) {
        yarp().write(*this);
        clean();
    }
}

// Editor: mark dirty overall
void SensorMetadata::Editor::mark_dirty()
{
    is_dirty = true;
}

// Editor: name mark_dirty
void SensorMetadata::Editor::mark_dirty_name()
{
    if (is_dirty_name) {
        return;
    }
    dirty_count++;
    is_dirty_name = true;
    mark_dirty();
}

// Editor: frameName mark_dirty
void SensorMetadata::Editor::mark_dirty_frameName()
{
    if (is_dirty_frameName) {
        return;
    }
    dirty_count++;
    is_dirty_frameName = true;
    mark_dirty();
}

// Editor: additionalMetadata mark_dirty
void SensorMetadata::Editor::mark_dirty_additionalMetadata()
{
    if (is_dirty_additionalMetadata) {
        return;
    }
    dirty_count++;
    is_dirty_additionalMetadata = true;
    mark_dirty();
}

// Editor: dirty_flags
void SensorMetadata::Editor::dirty_flags(bool flag)
{
    is_dirty = flag;
    is_dirty_name = flag;
    is_dirty_frameName = flag;
    is_dirty_additionalMetadata = flag;
    dirty_count = flag ? 3 : 0;
}

// read name field
bool SensorMetadata::read_name(yarp::os::idl::WireReader& reader)
{
    if (!reader.readString(name)) {
        reader.fail();
        return false;
    }
    return true;
}

// write name field
bool SensorMetadata::write_name(const yarp::os::idl::WireWriter& writer) const
{
    if (!writer.writeString(name)) {
        return false;
    }
    return true;
}

// read (nested) name field
bool SensorMetadata::nested_read_name(yarp::os::idl::WireReader& reader)
{
    if (!reader.readString(name)) {
        reader.fail();
        return false;
    }
    return true;
}

// write (nested) name field
bool SensorMetadata::nested_write_name(const yarp::os::idl::WireWriter& writer) const
{
    if (!writer.writeString(name)) {
        return false;
    }
    return true;
}

// read frameName field
bool SensorMetadata::read_frameName(yarp::os::idl::WireReader& reader)
{
    if (!reader.readString(frameName)) {
        reader.fail();
        return false;
    }
    return true;
}

// write frameName field
bool SensorMetadata::write_frameName(const yarp::os::idl::WireWriter& writer) const
{
    if (!writer.writeString(frameName)) {
        return false;
    }
    return true;
}

// read (nested) frameName field
bool SensorMetadata::nested_read_frameName(yarp::os::idl::WireReader& reader)
{
    if (!reader.readString(frameName)) {
        reader.fail();
        return false;
    }
    return true;
}

// write (nested) frameName field
bool SensorMetadata::nested_write_frameName(const yarp::os::idl::WireWriter& writer) const
{
    if (!writer.writeString(frameName)) {
        return false;
    }
    return true;
}

// read additionalMetadata field
bool SensorMetadata::read_additionalMetadata(yarp::os::idl::WireReader& reader)
{
    if (!reader.readString(additionalMetadata)) {
        reader.fail();
        return false;
    }
    return true;
}

// write additionalMetadata field
bool SensorMetadata::write_additionalMetadata(const yarp::os::idl::WireWriter& writer) const
{
    if (!writer.writeString(additionalMetadata)) {
        return false;
    }
    return true;
}

// read (nested) additionalMetadata field
bool SensorMetadata::nested_read_additionalMetadata(yarp::os::idl::WireReader& reader)
{
    if (!reader.readString(additionalMetadata)) {
        reader.fail();
        return false;
    }
    return true;
}

// write (nested) additionalMetadata field
bool SensorMetadata::nested_write_additionalMetadata(const yarp::os::idl::WireWriter& writer) const
{
    if (!writer.writeString(additionalMetadata)) {
        return false;
    }
    return true;
}
